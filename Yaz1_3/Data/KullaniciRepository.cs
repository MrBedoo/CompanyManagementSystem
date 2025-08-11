using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyManagementSystem.Models;
using Npgsql;
using System.ComponentModel.DataAnnotations;
using CompanyManagementSystem;
using CompanyManagementSystem.Helpers;

namespace CompanyManagementSystem.Data
{
    internal class KullaniciRepository : BaseRepository<Kullanici>
    {
        public Kullanici? GetByEmail(string email)
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();

            var sql = "SELECT * FROM kullanici WHERE email = @Email";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@Email", email);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Kullanici
                {
                    Id = Convert.ToInt32(reader["id"]),
                    Ad = reader["ad"].ToString() ?? "",
                    Soyad = reader["soyad"].ToString() ?? "",
                    Email = reader["email"].ToString() ?? "",
                    DogumTarihi = Convert.ToDateTime(reader["dogum_tarihi"]),
                    Cinsiyet = Convert.ToChar(reader["cinsiyet"]),
                    Gelir = Convert.ToDecimal(reader["gelir"]),
                    SifreHash = reader["sifre_hash"].ToString() ?? "",
                    Durum = reader["durum"] == DBNull.Value ? false : Convert.ToBoolean(reader["durum"]),
                    KayitZamani = Convert.ToDateTime(reader["kayit_zamani"]),
                    Resim = reader["resim"] as byte[],
                    RolId = reader["rol_id"] == DBNull.Value ? 0 : Convert.ToInt32(reader["rol_id"]),
                };
            }
            return null;
        }
    }
}
