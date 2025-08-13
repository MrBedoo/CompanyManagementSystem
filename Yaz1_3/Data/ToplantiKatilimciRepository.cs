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
        public void AddKatilimci(int toplantiId, int kullaniciId, string katilimDurumu, string rol)
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();

            string sql = @"INSERT INTO toplanti_katilimci (toplantiid, kullaniciid, katilimdurumu, rol) 
                   VALUES (@toplantiId, @kullaniciId, @katilimDurumu, @rol)";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@toplantiId", toplantiId);
            cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);
            cmd.Parameters.AddWithValue("@katilimDurumu", katilimDurumu);
            cmd.Parameters.AddWithValue("@rol", rol);

            cmd.ExecuteNonQuery();
        }


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
