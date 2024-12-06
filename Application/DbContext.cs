using System.Data.SqlClient;

namespace Application
{
    public class DbContext
    {
        private const string connectionString = "Host=localhost;Port=5432;Database=CarDb;Username=postgres;Password=1111;Include Error Detail=True";

        public async Task CreateTable(string tableName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string createTable = "";
            }
        }

        public async Task<List<T>> GetTable<T>(string tableName)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string sql = $"SELECT * FROM {tableName}";
                SqlCommand command = new SqlCommand(sql, connection);

                var datas = command.ExecuteReaderAsync();

                return new List<T>();
            }
        }
    }
}
