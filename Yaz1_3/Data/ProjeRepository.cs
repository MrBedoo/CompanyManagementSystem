using CompanyManagementSystem.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagementSystem.Data
{
    internal class ProjeRepository
    {

        public List<Proje> GetAll()
        {
            var list = new List<Proje>();

            using var conn = DbHelper.GetConnection();
            conn.Open();

            // Sadece ihtiyacın olan sütunları açıkça seç
            const string sql = @"
            SELECT id, ad, aciklama, bitistarihi
            FROM proje
            ORDER BY ad";

            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            // Sütun adlarından ordinal al -> sıra değişse de çalışır
            int ordId = reader.GetOrdinal("id");
            int ordAd = reader.GetOrdinal("ad");
            int ordAciklama = reader.GetOrdinal("aciklama");
            int ordBitisTarihi = reader.GetOrdinal("bitistarihi");

            while (reader.Read())
            {
                var proje = new Proje
                {
                    Id = reader.GetInt32(ordId),
                    Ad = reader.GetString(ordAd),
                    Aciklama = reader.IsDBNull(ordAciklama) ? "" : reader.GetString(ordAciklama),
                    // bitistarihi timestamp ise -> GetDateTime kullan
                    BitisTarihi = reader.IsDBNull(ordBitisTarihi) ? (DateTime?)null : reader.GetDateTime(ordBitisTarihi),
                };
                list.Add(proje);
            }
            return list;
        }

        
        public void Add(Proje proje)
        {
            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                var cmd = new NpgsqlCommand(@"
                INSERT INTO proje (ad, aciklama, baslangictarihi, bitistarihi, durum, yoneticiid)
                VALUES (@ad, @aciklama, @baslangictarihi, @bitistarihi, @durum, @yoneticiid)", conn);

                cmd.Parameters.AddWithValue("ad", proje.Ad);
                cmd.Parameters.AddWithValue("aciklama", (object)proje.Aciklama ?? DBNull.Value);
                cmd.Parameters.AddWithValue("baslangictarihi", (object)proje.BaslangicTarihi ?? DBNull.Value);
                cmd.Parameters.AddWithValue("bitistarihi", (object)proje.BitisTarihi ?? DBNull.Value);
                cmd.Parameters.AddWithValue("durum", proje.Durum);
                cmd.Parameters.AddWithValue("yoneticiid", proje.YoneticiId);

                cmd.ExecuteNonQuery();
            }
        }



    }
}
