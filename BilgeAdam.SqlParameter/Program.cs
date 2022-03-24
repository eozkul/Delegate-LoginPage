using System.Data.SqlClient;

namespace BilgeAdam.SqlParameterPractice
{
    internal class Program
    {
        public static void Main(string[] arg)
        {
            string connectionString = "Server=localhost,20000;Database=Northwind;User Id=sa;Password=Bilgeadam123!;";
            using var connection = new SqlConnection(connectionString);

            var query = "INSERT INTO Categories (CategoryName, Description) VALUES (@CategoryName, @Description)";
            connection.Open();
            var command = new SqlCommand(query, connection);
            //var param1 = new SqlParameter("@CategoryName", "Deneme");
            //var param2 = new SqlParameter("@Description", "Deneme verisidir");
            //command.Parameters.AddRange(new SqlParameter[] { param1, param2 });
            command.Parameters.AddRange(new SqlParameter[] {
                new SqlParameter("@CategoryName", "Deneme"),
                new SqlParameter("@Description", "Deneme verisidir")
            });
            //command.Parameters.Add(param1);
            //command.Parameters.Add(param2);
            var effectedRows = command.ExecuteNonQuery();
            Console.WriteLine(effectedRows);

            //var commandProcedur = new SqlCommand("dbo.sp_InsertCategory", connection);
            var commandProcedur = new SqlCommand();
            commandProcedur.CommandText = "dbo.sp_InsertCategory";
            commandProcedur.CommandType = System.Data.CommandType.StoredProcedure;
            commandProcedur.Connection = connection;

            var param1 = new SqlParameter("@Name", "Deneme3");
            var param2 = new SqlParameter("@Description", "Deneme3 verisidir");
            commandProcedur.Parameters.Add(param1);
            commandProcedur.Parameters.Add(param2);
            var effectedRowsForProcedure = commandProcedur.ExecuteNonQuery();
            Console.WriteLine(effectedRows);
        }
    }
}