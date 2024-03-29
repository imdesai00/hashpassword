//using hashpassword.Models;
//using Microsoft.AspNetCore.Authorization;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.ActionConstraints;
//using Npgsql;
//using System.Data;

//namespace hashpassword.Data
//{
//    public interface IUserRepository
//    {
//        bool ValidateCredentials(string username, string password);
//    }
//    public class UserRepository : IUserRepository
//    {
//        private readonly string _connectionString;

//        public UserRepository(IConfiguration configuration)
//        {
//            _connectionString = configuration.GetConnectionString("postgre");

//        }

//        public bool ValidateCredentials(string username, string password)
//        {
//            using (var connection = new NpgsqlConnection(_connectionString))
//            {
//                connection.Open();
//                using (var command = new NpgsqlCommand())
//                {
//                    command.Connection = connection;
//                    command.CommandText = "SELECT COUNT(*) FROM \"Users\" where \"UserName\" = @username and \"Password\" = @password;";
//                    command.Parameters.AddWithValue("@username", username);
//                    command.Parameters.AddWithValue("@password", password);

//                    return (Int64)command.ExecuteScalar() > 0;
//                }
//            }
//        }


//    }
//}
