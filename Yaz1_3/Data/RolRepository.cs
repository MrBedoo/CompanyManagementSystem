using CompanyManagementSystem.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagementSystem.Data
{
    internal class RolRepository
    {
        public List<Rol> GetAll()
        {
            var roller = new List<Rol>();

            using var conn = DbHelper.GetConnection();
            conn.Open();

            string query = "SELECT id, ad FROM rol";
            using var cmd = new NpgsqlCommand(query, conn);
            using var reader = cmd.ExecuteReader();

            while (reader.Read())
            {
                roller.Add(new Rol
                {
                    Id = reader.GetInt32(0),
                    Ad = reader.GetString(1)
                });
            }

            return roller;
        }

    }
}
