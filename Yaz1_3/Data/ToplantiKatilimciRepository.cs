using CompanyManagementSystem.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompanyManagementSystem.Data;

namespace CompanyManagementSystem.Data
{
    internal class ToplantiKatilimciRepository
    {
       

        public List<ToplantiKatilimci> GetByToplantiId(int toplantıId)
        {
            var list = new List<ToplantiKatilimci>();
            string sql = @"SELECT id, toplantiid, kullaniciid, katilimdurumu, rol
                   FROM toplanti_katilimci
                   WHERE toplantiid = @toplantiId";

            using var conn = DbHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("toplantiId", toplantıId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new ToplantiKatilimci
                {
                    Id = reader.GetInt32(0),
                    ToplantiId = reader.GetInt32(1),
                    KullaniciId = reader.GetInt32(2),
                    KatilimDurumu = reader.IsDBNull(3) ? "" : reader.GetString(3),
                    Rol = reader.IsDBNull(4) ? "" : reader.GetString(4)
                });
            }

            return list;
        }


    }
}
