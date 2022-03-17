using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace BilgeAdam.Data
{
    public class DatabaseManager
    {
        private readonly SqlConnection connection;

        public DatabaseManager()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["NrthwConnectionString"].ConnectionString);
        }

        public bool Any(string query)
        {
            OpenConnection();
            var command = new SqlCommand(query, connection);
            var result = command.ExecuteScalar();
            CloseConnection();
            return result is not null; //result != null
        }

        private void OpenConnection()
        {
            if (connection.State != ConnectionState.Open)
            {
                connection.Open();
            }
        }

        private void CloseConnection()
        {
            if (connection.State != ConnectionState.Closed)
            {
                connection.Close();
            }
        }
    }
}