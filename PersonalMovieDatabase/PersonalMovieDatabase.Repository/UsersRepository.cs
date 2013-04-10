using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using PersonalMovieDatabase.Common.Configuration;
using PersonalMovieDatabase.Domain;
using Dapper;

namespace PersonalMovieDatabase.Repository
{
    public class UsersRepository : IUsersRepository
    {
        private readonly IConfig _config;

        public UsersRepository(IConfig config)
        {
            _config = config;
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
            //using (var sqlConnection = new SqlConnection(_config.SqlConnectionString))
            //{
            //    sqlConnection.Open();

            //    IEnumerable<Users> users = sqlConnection.("Select * from Products");

            //    foreach (Product product in products)
            //    {
            //        ObjectDumper.Write(product);
            //    }
            //    sqlConnection.Close();
            //}
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
