using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VsExport.db
{
    class DBConnection
    {
        public static SqlConnection SqlConnect;

        public static SqlConnection CreateDBConnection(string datasource, string database, string username, string password)
        {
            //string datasource = @"localhost";
            //string database = "kr1";
            //string username = "sa";
            //string password = "123";

            string connString = $"Data Source={datasource};Initial Catalog={database};Persist Security Info=True;User ID={username};Password={password}";

            SqlConnect = new SqlConnection(connString);

            return SqlConnect;
        }
    }
}
