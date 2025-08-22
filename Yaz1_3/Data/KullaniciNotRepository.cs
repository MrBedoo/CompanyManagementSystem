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

            string query = "SELECT Id, GonderenId, HedefKullaniciId, NotTarihi, NotMetni, Turu " +
                           "FROM KullaniciNotlari WHERE HedefKullaniciId = @KullaniciId ORDER BY NotTarihi DESC";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@KullaniciId", kullaniciId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                notlar.Add(new KullaniciNot
                {
                    Id = reader.GetInt32(reader.GetOrdinal("Id")),
                    GonderenId = reader.GetInt32(reader.GetOrdinal("GonderenId")),
                    HedefKullaniciId = reader.GetInt32(reader.GetOrdinal("HedefKullaniciId")),
                    NotTarihi = reader.GetDateTime(reader.GetOrdinal("NotTarihi")),
                    NotMetni = reader.GetString(reader.GetOrdinal("NotMetni")),
                    Turu = (NotTuru)reader.GetInt16(reader.GetOrdinal("Turu")),
                });
            }

            return notlar;
        }

        public void Add(KullaniciNot not)
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();

            string query = "INSERT INTO KullaniciNotlari (GonderenId, HedefKullaniciId, NotTarihi, NotMetni, Turu) " +
                           "VALUES (@GonderenId, @HedefKullaniciId, @NotTarihi, @NotMetni, @Turu)";
            using var cmd = new NpgsqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@GonderenId", not.GonderenId);
            cmd.Parameters.AddWithValue("@HedefKullaniciId", not.HedefKullaniciId);
            cmd.Parameters.AddWithValue("@NotTarihi", not.NotTarihi);
            cmd.Parameters.AddWithValue("@NotMetni", not.NotMetni);
            cmd.Parameters.AddWithValue("@Turu", (short)not.Turu);  // <-- enum'u smallint olarak gönder

            cmd.ExecuteNonQuery();
        }


       




    }
}
