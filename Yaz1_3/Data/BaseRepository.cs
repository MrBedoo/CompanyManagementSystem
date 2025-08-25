using CompanyManagementSystem.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompanyManagementSystem.Data
{
    internal class BaseRepository<T> where T : class, new()
    {

        public int RunInsertOrUpdate(T entity)
        {
            var type = typeof(T);
            var tableName = type.Name.ToLower();
            var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                            .Where(p => p.CanRead)
                            .ToList();

            var idProp = props.FirstOrDefault(p => string.Equals(p.Name, "Id", StringComparison.OrdinalIgnoreCase));
            if (idProp == null)
                throw new Exception("Entity'de 'Id' property bulunamadı.");

            var idValue = idProp.GetValue(entity);
            bool isInsert = idValue == null || Convert.ToInt32(idValue) == 0;

            try
            {
                using var conn = DbHelper.GetConnection();
                conn.Open();
                using var cmd = new NpgsqlCommand { Connection = conn };
                if (isInsert)
                {
                    try
                    {
                        var columns = props.Where(p => p != idProp)
                                           .Select(p => "\"" + p.Name.ToLower() + "\"")
                                           .ToList();
                        var parameters = columns.Select(c => "@" + c.Trim('"')).ToList();

                        cmd.CommandText = $"INSERT INTO \"{tableName}\" ({string.Join(", ", columns)}) " +
                                          $"VALUES ({string.Join(", ", parameters)}) RETURNING \"{idProp.Name.ToLower()}\";";

                        foreach (var prop in props.Where(p => p != idProp))
                            cmd.Parameters.AddWithValue("@" + prop.Name.ToLower(), prop.GetValue(entity) ?? DBNull.Value);

                        var result = cmd.ExecuteScalar();
                        idProp.SetValue(entity, Convert.ToInt32(result));

                        return 0; // yeni kayıt eklendi
                    }
                    catch (PostgresException ex) when (ex.SqlState == "23505") // unique violation
                    {
                        return -2; // aynı ad/soyad/email
                    }
                }
                else
                {
                    var setClauses = props.Where(p => p != idProp)
                                          .Select(p => $"\"{p.Name.ToLower()}\" = @{p.Name.ToLower()}")
                                          .ToList();

                    cmd.CommandText = $"UPDATE \"{tableName}\" SET {string.Join(", ", setClauses)} " +
                                      $"WHERE \"{idProp.Name.ToLower()}\" = @{idProp.Name.ToLower()}";

                    foreach (var prop in props)
                        cmd.Parameters.AddWithValue("@" + prop.Name.ToLower(), prop.GetValue(entity) ?? DBNull.Value);

                    int affected = cmd.ExecuteNonQuery();
                    if (affected > 0)
                        return 1; // güncelleme başarılı
                    else
                        return -1; // id bulunamadı
                }
            }
            catch (Npgsql.PostgresException ex) when (ex.SqlState == "23505") // unique_violation
            {
                // Hata mesajını kullanıcıya gösterebilirsin
                throw new Exception("Unique constraint ihlali: " + ex.Detail);
            }
            catch (Exception ex)
            {
                throw; // diğer hatalar için tekrar fırlat
            }
        }


        public List<T> GetByAtananKullaniciId(int kullaniciId)
        {
            var type = typeof(T);
            var tableName = ToDbTableName(type.Name);

            var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                            .Where(p => p.CanRead && p.CanWrite)
                            .ToList();

            // Aranacak kolon ismini property'den dönüştürüyoruz
            var columnName = ToDbColumnName("AtananKullaniciId");

            var sql = $"SELECT * FROM \"{tableName}\" WHERE \"{columnName}\" = @kullaniciId";

            using var conn = DbHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);

            using var reader = cmd.ExecuteReader();

            var result = new List<T>();

            while (reader.Read())
            {
                var entity = new T();

                foreach (var prop in props)
                {
                    var dbCol = ToDbColumnName(prop.Name);

                    int ordinal;
                    try
                    {
                        ordinal = reader.GetOrdinal(dbCol);
                    }
                    catch (IndexOutOfRangeException)
                    {
                        continue; // DB'de kolon yoksa atla
                    }

                    if (reader.IsDBNull(ordinal))
                    {
                        prop.SetValue(entity, null);
                        continue;
                    }

                    var propType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;
                    var value = reader.GetValue(ordinal);

                    prop.SetValue(entity, Convert.ChangeType(value, propType));
                }

                result.Add(entity);
            }

            return result;
        }



        public List<T> Listele<T>() where T : new()
        {
            var liste = new List<T>();
            var type = typeof(T);

            using var conn = DbHelper.GetConnection();
            conn.Open();

            var sql = $"SELECT * FROM {ToDbTableName(type.Name)}";
            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var entity = new T();

                foreach (var prop in type.GetProperties())
                {
                    var columnName = ToDbColumnName(prop.Name);
                    int ordinal;

                    try
                    {
                        ordinal = reader.GetOrdinal(columnName);
                    }
                    catch (IndexOutOfRangeException)
                    {
                        // Kolon yoksa atla
                        continue;
                    }

                    if (!reader.IsDBNull(ordinal))
                    {
                        var value = reader.GetValue(ordinal);
                        var propType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;

                        if (propType == typeof(char))
                        {
                            if (value is string s && s.Length == 1)
                                prop.SetValue(entity, s[0]);
                            else
                                prop.SetValue(entity, default(char));
                        }
                        else
                        {
                            prop.SetValue(entity, Convert.ChangeType(value, propType));
                        }
                    }
                    else
                    {
                        // Null ise nullable property ise null atayabilir
                        if (Nullable.GetUnderlyingType(prop.PropertyType) != null || !prop.PropertyType.IsValueType)
                            prop.SetValue(entity, null);
                        else
                            prop.SetValue(entity, Activator.CreateInstance(prop.PropertyType));
                    }
                }

                liste.Add(entity);
            }

            return liste;
        }


        public void Sil<T>(int id)
        {
            var type = typeof(T);
            var tableName = ToDbTableName(type.Name);

            using var conn = DbHelper.GetConnection();
            conn.Open();

            string sql = $"DELETE FROM {tableName} WHERE id = @id";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
        }


        public T GetById(int id)
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();

            var tableName = ToDbTableName(typeof(T).Name);

            var sql = $"SELECT * FROM {tableName} WHERE id = @id";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();

            if (!reader.Read())
                return default;

            var entity = Activator.CreateInstance<T>();
            var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            foreach (var prop in props)
            {
                // Kolon adını dönüştür
                var columnName = ToDbColumnName(prop.Name);

                int ordinal;
                try
                {
                    ordinal = reader.GetOrdinal(columnName);
                }
                catch (IndexOutOfRangeException)
                {
                    // Bu property veritabanında yoksa atla
                    continue;
                }

                if (reader.IsDBNull(ordinal))
                {
                    prop.SetValue(entity, null);
                    continue;
                }

                var value = reader.GetValue(ordinal);

                // Nullable desteği
                var targetType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;

                try
                {
                    var safeValue = Convert.ChangeType(value, targetType);
                    prop.SetValue(entity, safeValue);
                }
                catch
                {
                    // Tip uyuşmazlığı olursa direkt raw value set edilir
                    prop.SetValue(entity, value);
                }
            }

            return entity;
        }


        public List<T> GetAll()
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();

            var tableName = ToDbTableName(typeof(T).Name);

            var sql = $"SELECT * FROM {tableName}";
            using var cmd = new NpgsqlCommand(sql, conn);

            using var reader = cmd.ExecuteReader();
            var entities = new List<T>();
            var props = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance);

            while (reader.Read())
            {
                var entity = Activator.CreateInstance<T>();

                foreach (var prop in props)
                {
                    var columnName = ToDbColumnName(prop.Name);

                    int ordinal;
                    try
                    {
                        ordinal = reader.GetOrdinal(columnName);
                    }
                    catch (IndexOutOfRangeException)
                    {

                        continue;
                    }

                    if (reader.IsDBNull(ordinal))
                    {
                        prop.SetValue(entity, null);
                        continue;
                    }

                    var value = reader.GetValue(ordinal);
                    var targetType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;

                    try
                    {
                        var safeValue = Convert.ChangeType(value, targetType);
                        prop.SetValue(entity, safeValue);
                    }
                    catch
                    {
                        prop.SetValue(entity, value);
                    }

                }
                entities.Add(entity);

            }

            return entities;
        }


        public int Add(T entity)
        {
            var type = typeof(T);
            var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                            .Where(p => p.CanRead)
                            .ToList();

            var idProp = props.FirstOrDefault(p =>
                string.Equals(p.Name, "Id", StringComparison.OrdinalIgnoreCase));

            if (idProp == null)
                throw new Exception("Entity'de 'Id' property bulunamadı.");

            // Id hariç property’ler
            var columns = props.Where(p => p != idProp)
                               .Select(p => "\"" + p.Name.ToLower() + "\"")
                               .ToList();

            var parameters = props.Where(p => p != idProp)
                                  .Select(p => "@" + p.Name.ToLower())
                                  .ToList();

            var _tableName = ToDbTableName(typeof(T).Name);

            var sql = $"INSERT INTO \"{_tableName}\" ({string.Join(", ", columns)}) " +
                      $"VALUES ({string.Join(", ", parameters)}) RETURNING \"{idProp.Name.ToLower()}\";";

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    foreach (var prop in props.Where(p => p != idProp))
                    {
                        var value = prop.GetValue(entity) ?? DBNull.Value;

                        // Eğer enum ise -> string ya da int'e dönüştür
                        if (value is Enum enumValue)
                        {
                            // Veritabanında nasıl saklıyorsan ona göre seç
                            value = Convert.ToInt32(enumValue); // kolon int4 olsaydı bunu kullanırdın
                                                                // value = Convert.ToInt32(enumValue); // integer alanı için
                        }

                        cmd.Parameters.AddWithValue("@" + prop.Name.ToLower(), value);
                    }

                    var result = cmd.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        idProp.SetValue(entity, Convert.ToInt32(result));
                        return Convert.ToInt32(result);
                    }
                    else
                    {
                        throw new Exception("Insert başarısız oldu, Id döndürülmedi.");
                    }
                }
            }
        }


        public int Update(T entity)
        {
            var type = typeof(T);
            var tableName = ToDbTableName(type.Name);
            var props = type.GetProperties(BindingFlags.Public | BindingFlags.Instance)
                            .Where(p => p.CanRead)
                            .ToList();

            var idProp = props.FirstOrDefault(p =>
                string.Equals(p.Name, "Id", StringComparison.OrdinalIgnoreCase));

            if (idProp == null)
                throw new Exception("Entity'de 'Id' property bulunamadı.");

            var idValue = idProp.GetValue(entity);
            if (idValue == null || Convert.ToInt32(idValue) == 0)
                throw new Exception("Update için geçerli bir Id değeri bulunamadı.");

            var setClauses = props.Where(p => p != idProp)
                                  .Select(p => $"\"{ToDbColumnName(p.Name)}\" = @{ToDbColumnName(p.Name)}")
                                  .ToList();

            var sql = $"UPDATE \"{tableName}\" SET {string.Join(", ", setClauses)} " +
                      $"WHERE \"{ToDbColumnName(idProp.Name)}\" = @{ToDbColumnName(idProp.Name)}";

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    foreach (var prop in props)
                    {
                        var value = prop.GetValue(entity) ?? DBNull.Value;
                        cmd.Parameters.AddWithValue("@" + ToDbColumnName(prop.Name), value);
                    }

                    return cmd.ExecuteNonQuery();
                }
            }
        }






        // Sınıf adını tablo adına dönüştür (ör: Kullanici => kullanicilar)
        private string ToDbTableName(string className)
        {
            // Basit dönüşüm, ihtiyaca göre geliştir
            return className.ToLower();
        }

        // Property adını db kolon adına dönüştür (ör: DogumTarihi => dogum_tarihi)
        private string ToDbColumnName(string propName)
        {
            return propName.ToLower();

        }





    }
}
