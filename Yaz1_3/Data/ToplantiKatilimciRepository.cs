using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagementSystem.Data
{
    internal class ToplantiKatilimciRepository
    {
        public void ToplantiyaKatilimciEkle(int toplantiId, int kullaniciId)
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();

            var sql = "INSERT INTO toplanti_katilimcilar (toplanti_id, kullanici_id) VALUES (@toplantiId, @kullaniciId)";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@toplantiId", toplantiId);
            cmd.Parameters.AddWithValue("@kullaniciId", kullaniciId);

            cmd.ExecuteNonQuery();
        }
    }
}
