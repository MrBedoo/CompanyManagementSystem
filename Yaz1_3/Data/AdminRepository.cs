using CompanyManagementSystem.Models;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManagementSystem.Data
{
    internal class AdminRepository
    {

        public bool BaskaAdmindeVarMi(Admin admin)
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();

            string sql = @"
            SELECT COUNT(*) FROM admin
            WHERE (ad = @ad OR soyad = @soyad OR email = @email)
            AND id <> @id"; // Burada id farkı kontrolü var

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@ad", admin.Ad);
            cmd.Parameters.AddWithValue("@soyad", admin.Soyad);
            cmd.Parameters.AddWithValue("@email", admin.Email);
            cmd.Parameters.AddWithValue("@id", admin.Id);

            int count = Convert.ToInt32(cmd.ExecuteScalar());
            return count > 0;
        }

    }
}
