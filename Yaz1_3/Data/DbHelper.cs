using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace CompanyManagementSystem.Data
{
    internal class DbHelper
    {
        private static readonly string connectionString = "********";

        public static string ConnectionString => connectionString;

        public static NpgsqlConnection GetConnection()
        {
            return new NpgsqlConnection(connectionString);
        }

    }
}

