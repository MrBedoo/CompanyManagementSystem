using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;

namespace CompanyManagementSystem.Data
{
    internal class DbHelper
    {
        private static readonly string connectionString = "Host=localhost;Port=5432;Database=Yaz1;Username=postgres;Password=Bedo123;Include Error Detail=true";

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }

    }
}
