using System;
using System.Collections.Generic;
using Ninject.Extensions.Logging;
using PersonalMovieDatabase.Domain;
using PersonalMovieDatabase.Repository;

namespace PersonalMovieDatabase.Core
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository _userRepository;
        private readonly ILogger _logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserManager"/> class.
        /// </summary>
        /// <param name="userRepository">The user repository.</param>
        /// <param name="logger">The logger.</param>
        public UserManager(IUserRepository userRepository, ILogger logger)
        {
            _userRepository = userRepository;
            _logger = logger;
        }

        /// <summary>
        /// Creates the user.
        /// </summary>
        /// <returns></returns>
        public int CreateUser(User user)
        {
            _logger.Debug("Inside Manager");
            _userRepository.CreateUser(user); 
            return _userRepository.CreateUser(user); 
        }

        /// <summary>
        /// Gets all users.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<User> GetAllUsers()
        {
            return _userRepository.GetAllUsers();
        }

    }
}
