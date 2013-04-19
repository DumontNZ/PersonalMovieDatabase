using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using PersonalMovieDatabase.Domain;
using Dapper;

namespace PersonalMovieDatabase.Repository
{
    public class UserRepository : IUserRepository
    {
       

        public UserRepository()
        {
            
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
            var connectionString =
                 System.Web.Configuration.WebConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;

            using(var sqlConnection = new MySqlConnection(connectionString))
            {
                sqlConnection.Open();
                IEnumerable<User> users = sqlConnection.Query<User>("Select * from User");

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
