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

            string sql = "SELECT id, baslik, aciklama, baslamatarihi, adres, olusturanid, bitistarihi, toplantituru, durum, olusturmatarihi FROM toplanti ORDER BY baslamatarihi DESC";

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


    }

}
