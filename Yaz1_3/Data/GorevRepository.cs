using CompanyManagementSystem.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagementSystem.Data
{
    internal class GorevRepository
    {
       

        public void Update(Gorev gorev)
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();

            string sql = @"UPDATE gorev
                   SET rapor = @rapor,
                       durum = @durum
                   WHERE id = @id";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@rapor", (object?)gorev.Rapor ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@durum", gorev.Durum);
            cmd.Parameters.AddWithValue("@id", gorev.Id);

            cmd.ExecuteNonQuery();
        }



        public List<Gorev> GetAll()
        {
            var list = new List<Gorev>();

            using var conn = DbHelper.GetConnection();
            conn.Open();

            string sql = @"
            SELECT id, projeid, atanankullaniciid, baslik, aciklama, durum, oncelik, olusturmatarihi, bitistarihi
            FROM gorev
            ORDER BY olusturmatarihi DESC";

            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var gorev = new Gorev
                {
                    Id = reader.GetInt32(0),
                    ProjeId = reader.IsDBNull(1) ? 0 : reader.GetInt32(1),
                    AtananKullaniciId = reader.IsDBNull(2) ? (int?)null : reader.GetInt32(2),
                    Baslik = reader.GetString(3),
                    Aciklama = reader.IsDBNull(4) ? "" : reader.GetString(4),
                    Durum = reader.IsDBNull(5) ? "Beklemede" : reader.GetString(5),
                    Oncelik = reader.IsDBNull(6) ? "Normal" : reader.GetString(6),
                    OlusturmaTarihi = reader.GetDateTime(7),
                    BitisTarihi = reader.IsDBNull(8) ? (DateTime?)null : reader.GetDateTime(8)
                };

                list.Add(gorev);
            }

            return list;
        }


        public List<Gorev> GetByAtananKullaniciId(int kullaniciId)
        {
            var gorevler = new List<Gorev>();

            using (var conn = DbHelper.GetConnection())
            {
                conn.Open();
                string sql = "SELECT * FROM Gorev WHERE AtananKullaniciId = @kullaniciId";

                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            gorevler.Add(new Gorev
                            {
                                Id = reader.GetInt32(reader.GetOrdinal("Id")),
                                ProjeId = reader.GetInt32(reader.GetOrdinal("ProjeId")),
                                AtananKullaniciId = reader.IsDBNull(reader.GetOrdinal("AtananKullaniciId"))
                                                     ? null
                                                     : reader.GetInt32(reader.GetOrdinal("AtananKullaniciId")),
                                Baslik = reader.GetString(reader.GetOrdinal("Baslik")),
                                Aciklama = reader.GetString(reader.GetOrdinal("Aciklama")),
                                Durum = reader.GetString(reader.GetOrdinal("Durum")),
                                Rapor = reader.IsDBNull(reader.GetOrdinal("Rapor")) ? "" : reader.GetString(reader.GetOrdinal("Rapor")),
                                Mesaj = reader.IsDBNull(reader.GetOrdinal("Mesaj")) ? "" : reader.GetString(reader.GetOrdinal("Mesaj")),
                                Oncelik = reader.IsDBNull(reader.GetOrdinal("Oncelik"))
                                          ? null
                                          : reader.GetString(reader.GetOrdinal("Oncelik")),
                                OlusturmaTarihi = reader.GetDateTime(reader.GetOrdinal("OlusturmaTarihi")),
                                BitisTarihi = reader.IsDBNull(reader.GetOrdinal("BitisTarihi"))
                                              ? (DateTime?)null
                                              : reader.GetDateTime(reader.GetOrdinal("BitisTarihi"))
                            });
                        }
                    }
                }
            }

            return gorevler;
        }





    }
}
