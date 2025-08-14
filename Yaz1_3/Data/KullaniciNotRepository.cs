using CompanyManagementSystem.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagementSystem.Data
{
    internal class KullaniciNotRepository
    {

        public List<KullaniciNot> GetByKullaniciId(int kullaniciId)
        {
            var notlar = new List<KullaniciNot>();

            using var conn = DbHelper.GetConnection();
            conn.Open();

            string query = "SELECT Id, KullaniciId, NotTarihi, NotMetni FROM KullaniciNotlari WHERE KullaniciId = @KullaniciId ORDER BY NotTarihi DESC";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@KullaniciId", kullaniciId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                notlar.Add(new KullaniciNot
                {
                    Id = reader.GetInt32(0),
                    KullaniciId = reader.GetInt32(1),
                    NotTarihi = reader.GetDateTime(2),
                    NotMetni = reader.GetString(3)
                });
            }

            return notlar;
        }

        public void Add(KullaniciNot not)
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();

            string query = "INSERT INTO KullaniciNotlari (KullaniciId, NotTarihi, NotMetni) VALUES (@KullaniciId, @NotTarihi, @NotMetni)";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@KullaniciId", not.KullaniciId);
            cmd.Parameters.AddWithValue("@NotTarihi", not.NotTarihi);
            cmd.Parameters.AddWithValue("@NotMetni", not.NotMetni);
            cmd.ExecuteNonQuery();
        }


    }
}
