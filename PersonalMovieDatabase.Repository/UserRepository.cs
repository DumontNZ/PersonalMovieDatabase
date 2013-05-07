using System.Linq;
using Dapper;
using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;

using PersonalMovieDatabase.Domain;

namespace PersonalMovieDatabase.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString ; 

        public UserRepository()
        {
            _connectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;
        }

        public User CreateUser(User user)
        {
            //using (MySqlConnection dbConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["connstring"].ConnectionString))
            //{
            //  //   Database work done here 
            //}
            throw new NotImplementedException();
        }

        public IEnumerable<User> GetAllUsers()
        {
            using (var sqlConnection = new MySqlConnection(_connectionString))
            {
                sqlConnection.Open();
                IEnumerable<User> users = sqlConnection.Query<User>("Select * from User where UserId = @UserId", new{UserId=2}).ToList();

                return users;
            }
        }

        public User GetUser(int userId)
        {
            throw new NotImplementedException();
        }

        public User GetUser(string username)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int userId)
        {
            throw new NotImplementedException();
        }

        public void Deleteuser(string username)
        {
            throw new NotImplementedException();
        }
    }
}
