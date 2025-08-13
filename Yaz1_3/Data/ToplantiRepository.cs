using CompanyManagementSystem.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagementSystem.Data
{
    internal class ToplantiRepository
    {

        public List<Toplanti> GetToplantilar()
        {
            var list = new List<Toplanti>();

            using var conn = DbHelper.GetConnection();
            conn.Open();

            string sql = "SELECT id, baslik, aciklama, baslama_tarihi, adres, olusturanid, bitis_tarihi, toplanti_turu, durum, olusturmatarihi FROM toplanti ORDER BY baslama_tarihi DESC";

            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var toplantı = new Toplanti
                {
                    Id = reader.GetInt32(0),
                    Baslik = reader.GetString(1),
                    Aciklama = reader.IsDBNull(2) ? "" : reader.GetString(2),
                    BaslamaTarihi = reader.GetDateTime(3),
                    Adres = reader.IsDBNull(4) ? "" : reader.GetString(4),
                    OlusturanId = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                    BitisTarihi = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6),
                    ToplantiTuru = reader.IsDBNull(7) ? "" : reader.GetString(7),
                    Durum = reader.IsDBNull(8) ? "Planlandı" : reader.GetString(8),
                    OlusturmaTarihi = reader.IsDBNull(9) ? DateTime.Now : reader.GetDateTime(9),
                };
                list.Add(toplantı);
            }

            return list;
        }


        public List<Toplanti> GetAll()
        {
            var list = new List<Toplanti>();

            using var conn = DbHelper.GetConnection();
            conn.Open();

            var cmd = new NpgsqlCommand("SELECT * FROM toplanti ORDER BY baslama_tarihi DESC", conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                list.Add(new Toplanti
                {
                    Id = reader.GetInt32(reader.GetOrdinal("id")),
                    Baslik = reader.GetString(reader.GetOrdinal("baslik")),
                    Aciklama = reader.IsDBNull(reader.GetOrdinal("aciklama")) ? null : reader.GetString(reader.GetOrdinal("aciklama")),
                    BaslamaTarihi = reader.GetDateTime(reader.GetOrdinal("baslama_tarihi")),
                    BitisTarihi = reader.GetDateTime(reader.GetOrdinal("bitis_tarihi")),
                    ToplantiTuru = reader.GetString(reader.GetOrdinal("toplanti_turu")),
                    Adres = reader.IsDBNull(reader.GetOrdinal("adres")) ? null : reader.GetString(reader.GetOrdinal("konum_veya_link"))
                });
            }

            return list;
        }

        public void Add(Toplanti t)
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();

            var sql = @"
            INSERT INTO toplanti 
            (baslik, aciklama, baslama_tarihi, adres, olusturanid, bitis_tarihi, toplanti_turu) 
            VALUES (@baslik, @aciklama, @baslama, @adres, @olusturanid, @bitis, @tur)";

            using var cmd = new NpgsqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@baslik", t.Baslik);
            cmd.Parameters.AddWithValue("@aciklama", (object?)t.Aciklama ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@baslama", t.BaslamaTarihi);
            cmd.Parameters.AddWithValue("@bitis", t.BitisTarihi);
            cmd.Parameters.AddWithValue("@tur", t.ToplantiTuru);
            cmd.Parameters.AddWithValue("@adres", (object?)t.Adres ?? DBNull.Value);
            cmd.Parameters.AddWithValue("@olusturanid", t.OlusturanId);

            cmd.ExecuteNonQuery();

            // Katılımcıları eklemek için ayrıca metod yazılır (eğer ayrı tabloda saklanıyorsa)


        }


        public Toplanti? GetById(int id)
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();

            var sql = "SELECT * FROM toplanti WHERE id = @id";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@id", id);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Toplanti
                {
                    Id = reader.GetInt32(0),
                    Baslik = reader.GetString(1),
                    Aciklama = reader.IsDBNull(2) ? "" : reader.GetString(2),
                    BaslamaTarihi = reader.GetDateTime(3),
                    Adres = reader.IsDBNull(4) ? "" : reader.GetString(4),
                    OlusturanId = reader.IsDBNull(5) ? 0 : reader.GetInt32(5),
                    BitisTarihi = reader.IsDBNull(6) ? (DateTime?)null : reader.GetDateTime(6),
                    ToplantiTuru = reader.IsDBNull(7) ? "" : reader.GetString(7),
                    Durum = reader.IsDBNull(8) ? "Planlandı" : reader.GetString(8),
                    OlusturmaTarihi = reader.IsDBNull(9) ? DateTime.Now : reader.GetDateTime(9)
                };
            }

            return null;
        }




    }

}
