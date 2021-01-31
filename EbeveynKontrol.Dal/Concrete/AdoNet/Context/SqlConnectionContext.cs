using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EbeveynKontrol.Dal.Concrete.AdoNet.Context
{
    public class SqlConnectionContext
    {
        private static string _connectionString = @"Server=.\SQLEXPRESS;Database=EbeveynTakip;Trusted_Connection=True;";

        public static SqlConnection Connection()
        {
            SqlConnection sqlConnection = new SqlConnection(_connectionString);
            if (sqlConnection.State == ConnectionState.Closed)
                sqlConnection.Open();
            return sqlConnection;
        }
    }
}
