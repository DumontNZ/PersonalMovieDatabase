using Dapper;
using System;
using System.Linq;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using Ninject.Extensions.Logging;
using PersonalMovieDatabase.Domain;

namespace PersonalMovieDatabase.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly string _connectionString;
    //    private readonly ILogger _logger;

        public UserRepository()
        {
           // _logger = logger;
            _connectionString = System.Web.Configuration.WebConfigurationManager.ConnectionStrings["MySqlConnectionString"].ConnectionString;
        }

        /// <summary>
        /// Creates the user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        public int CreateUser(User user)
        {
            using (var sqlConnection = new MySqlConnection(_connectionString))
            {
                sqlConnection.Open();
                try
                {
                    var succcessful = sqlConnection.Execute
                   ("Insert into user(UserName, FirstName, Surname, Email, PasswordSalt, Password, Country) values(@UserName, @FirstName, @Surname, @Email, @PasswordSalt, @Password, @Country)", user);

                    return succcessful;
                }
                catch (MySqlException exception)
                {
                   // _logger.Info(exception.Message, "Unable to create user as user name is already in use");
                    return 0;
                }
            }
        }

        /// <summary>
        /// Gets all users.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> GetAllUsers()
        {
            using (var sqlConnection = new MySqlConnection(_connectionString))
            {
                sqlConnection.Open();
                IEnumerable<User> users = sqlConnection.Query<User>("Select * from User").ToList();

                return users;
            }
        }

        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public User GetUser(int userId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public User GetUser(User user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the user.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public User UpdateUser(int userId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Updates the user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        /// <exception cref="System.NotImplementedException"></exception>
        public User UpdateUser(User user)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deletes the user.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void DeleteUser(int userId)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Deleteusers the specified user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <exception cref="System.NotImplementedException"></exception>
        public void Deleteuser(User user)
        {
            throw new NotImplementedException();
        }
    }
}
