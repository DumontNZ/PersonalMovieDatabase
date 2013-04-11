using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using PersonalMovieDatabase.Domain;
using Dapper;

namespace PersonalMovieDatabase.Repository
{
    public class UsersRepository : IUsersRepository
    {
       

        public UsersRepository()
        {
            
        }

        public Users CreateUser(Users user)
        {
            //using (MySqlConnection dbConn = new MySqlConnection(ConfigurationManager.ConnectionStrings["connstring"].ConnectionString))
            //{
            //  //   Database work done here 
            //}
            throw new NotImplementedException();
        }

        public IEnumerable<Users> GetAllUsers()
        {
            var connectionString =
                 System.Web.Configuration.WebConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;

            using(var sqlConnection = new MySqlConnection(connectionString))
            {
                sqlConnection.Open();
                IEnumerable<Users> users = sqlConnection.Query<Users>("Select * from Users");

                return users;
            }
        }

        public Users GetUser(int userId)
        {
            throw new NotImplementedException();
        }

        public Users GetUser(string username)
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
