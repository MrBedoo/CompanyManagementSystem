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

        public List<ToplantiKatilimciView> GetKatilimcilarByToplantiId(int toplantiId)
        {
            var list = new List<ToplantiKatilimciView>();
            string sql = @"
                SELECT tk.KullaniciId, tk.Rol, tk.KatilimDurumu, k.Ad, k.Soyad
                FROM toplantikatilimci tk
                JOIN kullanici k ON tk.KullaniciId = k.Id
                WHERE tk.ToplantiId = @ToplantiId";

            using var conn = DbHelper.GetConnection();
            conn.Open();
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ToplantiId", toplantiId);

            using var reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                list.Add(new ToplantiKatilimciView
                {
                    KullaniciId = reader.GetInt32(0),
                    Rol = reader.IsDBNull(1) ? "" : reader.GetString(1),
                    KatilimDurumu = reader.IsDBNull(2) ? "" : reader.GetString(2),
                    Ad = reader.IsDBNull(3) ? "" : reader.GetString(3),
                    Soyad = reader.IsDBNull(4) ? "" : reader.GetString(4)
                });
            }

            return list;
        }


    }
}
