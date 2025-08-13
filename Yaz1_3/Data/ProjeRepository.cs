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

            string sql = "SELECT id, ad, aciklama, bitis_tarihi FROM proje ORDER BY ad";
            using var cmd = new NpgsqlCommand(sql, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                var proje = new Proje
                {
                    Id = reader.GetInt32(0),
                    Ad = reader.GetString(1),
                    Aciklama = reader.IsDBNull(2) ? "" : reader.GetString(2),
                    BitisTarihi = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4),
                };
                list.Add(proje);
            }

            return list;
        }

        public Proje GetById(int id)
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();

            string sql = "SELECT id, ad, aciklama, bitis_tarihi FROM proje WHERE id = @id";
            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("id", id);

            using var reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                return new Proje
                {
                    Id = reader.GetInt32(0),
                    Ad = reader.GetString(1),
                    Aciklama = reader.IsDBNull(2) ? "" : reader.GetString(2),
                    BitisTarihi = reader.IsDBNull(4) ? (DateTime?)null : reader.GetDateTime(4),
                };
            }

            return null;
        }


    }
}
