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

        public TResult GetAll<TResult>(string tableName, Func<SqlDataReader, TResult> securityQuestionMapper)
        {
            OpenConnection();
            var command = new SqlCommand($"SELECT * FROM {tableName}", connection);
            var reader = command.ExecuteReader();
            var result = securityQuestionMapper(reader);
            CloseConnection();
            return result;
        }

        public bool Execute(string query)
        {
            OpenConnection();
            var command = new SqlCommand(query, connection);
            var result = command.ExecuteNonQuery();
            CloseConnection();
            return result > 0;
        }

        public bool ExecuteWithParameter(string query, SqlParameter[] sqlParameters)
        {
            OpenConnection();
            var command = new SqlCommand(query, connection);
            command.Parameters.AddRange(sqlParameters);
            var result = command.ExecuteNonQuery();
            CloseConnection();
            return result > 0;
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