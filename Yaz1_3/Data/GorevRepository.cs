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
        public void Add(Gorev gorev)
        {
            using var conn = DbHelper.GetConnection();
            conn.Open();

            string sql = @"INSERT INTO gorev (baslik, aciklama, bitistarihi, atanankullaniciid)
                       VALUES (@baslik, @aciklama, @bitis, @atanan)";

            using var cmd = new NpgsqlCommand(sql, conn);
            cmd.Parameters.AddWithValue("@baslik", gorev.Baslik);
            cmd.Parameters.AddWithValue("@aciklama", gorev.Aciklama ?? "");
            cmd.Parameters.AddWithValue("@bitis", gorev.BitisTarihi);
            cmd.Parameters.AddWithValue("@atanan", gorev.AtananKullaniciId);

            cmd.ExecuteNonQuery();
        }


    }
}
