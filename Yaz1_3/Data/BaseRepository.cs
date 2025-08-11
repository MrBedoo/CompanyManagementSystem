using CompanyManagementSystem.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var props = type.GetProperties();

            // Id property'sini bul ve değerini al
            var idProp = props.FirstOrDefault(p => string.Equals(p.Name, "Id", StringComparison.OrdinalIgnoreCase));
            if (idProp == null)
                throw new Exception("Entity'de Id property bulunamadı.");

            var idValue = idProp.GetValue(entity);
            bool isUpdate = false;
            if (idValue != null && int.TryParse(idValue.ToString(), out int idInt))
            {
                isUpdate = idInt > 0;
            }

            using var conn = DbHelper.GetConnection();
            conn.Open();

            if (isUpdate)
            {
                // Update sorgusu dinamik oluşturuluyor (KayitTarihi hariç)
                var setClause = string.Join(", ", props
                    .Where(p => !string.Equals(p.Name, "Id", StringComparison.OrdinalIgnoreCase) &&
                                !string.Equals(p.Name, "KayitTarihi", StringComparison.OrdinalIgnoreCase))
                    .Select(p => $"{ToDbColumnName(p.Name)} = @{p.Name.ToLower()}"));

                var sql = $"UPDATE {ToDbTableName(type.Name)} SET {setClause} WHERE id = @id";

                using var cmd = new NpgsqlCommand(sql, conn);

                foreach (var p in props)
                {
                    if (string.Equals(p.Name, "KayitTarihi", StringComparison.OrdinalIgnoreCase) ||
                        string.Equals(p.Name, "Id", StringComparison.OrdinalIgnoreCase))
                        continue;

                    var paramName = "@" + p.Name.ToLower();
                    var value = p.GetValue(entity) ?? DBNull.Value;
                    cmd.Parameters.AddWithValue(paramName, value);
                }
                cmd.Parameters.AddWithValue("@id", idValue);

                int affected = cmd.ExecuteNonQuery();
                return affected > 0 ? 1 : -1;
            }
            else
            {
                // Insert sorgusu (KayitTarihi için DateTime.Now atanacak)
                var insertProps = props.Where(p => !string.Equals(p.Name, "Id", StringComparison.OrdinalIgnoreCase) &&
                                                   !string.Equals(p.Name, "KayitZamani", StringComparison.OrdinalIgnoreCase)).ToList();

                var columnList = insertProps.Select(p => ToDbColumnName(p.Name)).ToList();
                columnList.Add("kayit_zamani");
                var columns = string.Join(", ", columnList);

                var parameterList = insertProps.Select(p => "@" + p.Name.ToLower()).ToList();
                parameterList.Add("@kayit_zamani");
                var parameters = string.Join(", ", parameterList);


                var sql = $"INSERT INTO {ToDbTableName(type.Name)} ({columns}) VALUES ({parameters})";
                try
                {
                    using var cmd = new NpgsqlCommand(sql, conn);

                    foreach (var p in insertProps)
                    {
                        var paramName = "@" + p.Name.ToLower();
                        var value = p.GetValue(entity) ?? DBNull.Value;
                        cmd.Parameters.AddWithValue(paramName, value);
                    }
                    cmd.Parameters.AddWithValue("@kayit_zamani", DateTime.Now);

                    cmd.ExecuteNonQuery();
                    return 0;
                }
                catch (PostgresException ex) when (ex.SqlState == "23505")
                {
                    MessageBox.Show("eklenemez, bu email zaten var.");
                    return -2;
                }
            }
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

            var entity = new T();
            var props = typeof(T).GetProperties();

            foreach (var prop in props)
            {
                // Kolon adını dönüştür (PascalCase -> snake_case gibi)
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

                var propType = Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType;

                object value = propType switch
                {
                    Type t when t == typeof(int) => reader.IsDBNull(ordinal) ? 0 : reader.GetInt32(ordinal),
                    Type t when t == typeof(long) => reader.IsDBNull(ordinal) ? 0L : reader.GetInt64(ordinal),
                    Type t when t == typeof(decimal) => reader.IsDBNull(ordinal) ? 0m : reader.GetDecimal(ordinal),
                    Type t when t == typeof(double) => reader.IsDBNull(ordinal) ? 0d : reader.GetDouble(ordinal),
                    Type t when t == typeof(float) => reader.IsDBNull(ordinal) ? 0f : reader.GetFloat(ordinal),
                    Type t when t == typeof(bool) => reader.IsDBNull(ordinal) ? false : reader.GetBoolean(ordinal),
                    Type t when t == typeof(string) => reader.IsDBNull(ordinal) ? null : reader.GetString(ordinal),
                    Type t when t == typeof(DateTime) => reader.IsDBNull(ordinal) ? DateTime.MinValue : reader.GetDateTime(ordinal),
                    Type t when t == typeof(char) => reader.IsDBNull(ordinal) ? '\0' : reader.GetChar(ordinal),
                    Type t when t == typeof(byte[]) => reader.IsDBNull(ordinal) ? null : (byte[])reader[columnName],
                    _ => reader.IsDBNull(ordinal) ? null : reader.GetValue(ordinal)
                };

                prop.SetValue(entity, value);
            }

            return entity;
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
            return string.Concat(propName.SelectMany((ch, i) =>
                i > 0 && char.IsUpper(ch) ? new[] { '_', char.ToLower(ch) } : new[] { char.ToLower(ch) }));

        }

    }
}
