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

        public List<Kullanici> GetAktifKullanicilar()
        {
            var list = new List<Kullanici>();
            using var conn = DbHelper.GetConnection();
            conn.Open();

            string sql = "SELECT id, ad, soyad, email FROM kullanici WHERE durum = true";
            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Kullanici
                {
                    Id = reader.GetInt32(0),
                    Ad = reader.GetString(1),
                    Soyad = reader.GetString(2),
                    Email = reader.GetString(3)
                });
            }
            return list;
        }

        public void IncrementFailedLoginAttempts(int kullaniciId)
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();
            var sql = @"
            UPDATE kullanici 
            SET failed_login_attempts = failed_login_attempts + 1 
            WHERE id = @id";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", kullaniciId);
            cmd.ExecuteNonQuery();
        }

        public void ResetFailedLoginAttempts(int kullaniciId)
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();
            var sql = @"
            UPDATE kullanici 
            SET failed_login_attempts = 0, lockout_end_time = NULL
            WHERE id = @id";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", kullaniciId);
            cmd.ExecuteNonQuery();
        }

        public void SetLockout(int kullaniciId, DateTime lockoutEndTime)
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();
            var sql = @"
            UPDATE kullanici 
            SET lockout_end_time = @lockoutEndTime
            WHERE id = @id";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", kullaniciId);
            cmd.Parameters.AddWithValue("@lockoutEndTime", lockoutEndTime);
            cmd.ExecuteNonQuery();
        }


    }
}
