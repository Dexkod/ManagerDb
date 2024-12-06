using Npgsql;

namespace Db
{
    public class DbContext
    {
        private List<BaseEntity> entities;
        private const string connectionString = "Host=localhost;Port=5432;Database=CarDb;Username=postgres;Password=1111;Include Error Detail=True";

        public async Task CreateTable(string tableName)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string createTable = "";
            }
        }

        public async Task<List<T>> GetTable<T>(string tableName)
            where T : BaseEntity
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                await connection.OpenAsync();

                string sql = $"SELECT * FROM \"{tableName}\"";
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);

                List<T> list;

                using (NpgsqlDataReader reader = await command.ExecuteReaderAsync())
                {
                    switch (tableName)
                    {
                        case "User":
                            return FillUser(reader) as List<T>;
                        case "Cars":
                            return FillCars(reader) as List<T>;
                        default:
                            throw new ArgumentOutOfRangeException(nameof(T));
                    }
                }
            }
        }


        public async Task Insert<T>(string tableName, T model)
            where T : BaseEntity
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string sql = $"INSERT INTO * FROM \"{tableName}\"";

                var properties = model.GetType().GetProperties();
                sql += "(";

                foreach (var item in properties)
                {
                    sql += $"\"{item.Name}\"";
                }

                sql += ")\n VALUES (";

                var values = model.GetType().();

                foreach (var item in values)
                {
                    sql += $" {item}";
                }
                sql += ")";

                NpgsqlCommand command = new NpgsqlCommand(sql, connection);

                await command.ExecuteNonQueryAsync();
            }
        }

        public async Task Remove<T>(string tableName, T model)
            where T : BaseEntity
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                string sql = $"DELETE FROM \"{tableName}\"\n WHERE \"Id\" = {model.Id}";
                NpgsqlCommand command = new NpgsqlCommand(sql, connection);

                await command.ExecuteNonQueryAsync();
            }
        }

        private List<User> FillUser(NpgsqlDataReader reader)
        {
            List<User> list = new List<User>();

            while (reader.Read())
            {
                list.Add(new User()
                {
                    Id = Convert.ToInt32(reader[nameof(User.Id)]),
                    FirstName = reader[nameof(User.FirstName)].ToString()!,
                    LastName = reader[nameof(User.LastName)].ToString()!,
                    Phone = reader[nameof(User.Phone)].ToString()!,
                });
            }

            return list;
        }

        private List<Cars> FillCars(NpgsqlDataReader reader)
        {
            List<Cars> list = new List<Cars>();

            while (reader.Read())
            {
                int userId = -1;

                int.TryParse(reader[nameof(Cars.UserId)].ToString(), out userId);

                list.Add(new Cars()
                {
                    Id = Convert.ToInt32(reader[nameof(Cars.Id)]),
                    Price = Convert.ToInt32(reader[nameof(Cars.Price)]),
                    Name = reader[nameof(Cars.Name)].ToString()!,
                    Power = Convert.ToInt32(reader[nameof(Cars.Power)]),
                    Color = reader[nameof(Cars.Color)].ToString(),
                    UserId = userId < 1 ? null : userId
                });
            }

            return list;
        }
    }
}
