using hashpassword.Models;
using Npgsql;
using System.Data;

namespace hashpassword.DataAccess
{
    public class AuthDataAcsess
    {
        private readonly string? _connectionString;

        public AuthDataAcsess(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("postgre");
        }

        public bool registeruser(User user)
        {
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand("insert into \"Users\" (\"UserName\",\"PhoneNo\",\"Email\",\"Password\",\"Salt\") values (@username,@phoneno,@email,@password,@salt);", connection))
                {
                    command.Parameters.AddWithValue("@username", user.UserName);
                    command.Parameters.AddWithValue("@phoneno", user.PhoneNo);
                    command.Parameters.AddWithValue("@email", user.Email);
                    command.Parameters.AddWithValue("@password", user.Password);
                    command.Parameters.AddWithValue("@salt", user.Salt);
                    command.ExecuteNonQuery();
                }
            }
            return true;
        }
        public async Task<User> FindEmailAsync(string Email)
        {
            var users = new User();
            DataSet ds = new DataSet();
            using (var connection = new NpgsqlConnection(_connectionString))
            {
                connection.Open();
                using (var command = new NpgsqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "SELECT * FROM \"Users\" where \"Email\" = @email";
                    command.Parameters.AddWithValue("@email", Email);
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return new User
                            {
                                Id = Convert.ToInt32(reader["Id"]),
                                UserName = Convert.ToString(reader["UserName"]),
                                PhoneNo = Convert.ToInt64(reader["PhoneNo"]),
                                Email = Convert.ToString(reader["Email"]),
                                Password = Convert.ToString(reader["Password"]),
                                Salt = Convert.ToString(reader["Salt"])

                            };
                        }
                    }

                }
            }
            return null;
        }
    }
}
