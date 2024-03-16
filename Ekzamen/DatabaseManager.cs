using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace Ekzamen
{
    internal class DatabaseManager
    {
        private NpgsqlConnection connection;

        public DatabaseManager(string connectionString)
        {
            connection = new NpgsqlConnection(connectionString);
        }

        public DataTable GetProductData()
        {
            DataTable dt = new DataTable();

            try
            {
                connection.Open();
                string sql = "Select id, article, name, typeproduct, imagepath, numpeople, cexnumber, agentprice, descript FROM Product";
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, connection);
                da.Fill(dt);
            }
            finally
            {
                connection.Close();
            }

            return dt;
        }
    }
}
