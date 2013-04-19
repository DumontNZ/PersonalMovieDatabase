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

        public UserManager(IUserRepository userRepository, ILogger logger)
        {
            _userRepository = userRepository;
            _logger = logger;
        }

        public void Testin()
        {
            _logger.Debug("Inside Manager");
            IEnumerable<User> users = _userRepository.GetAllUsers();
            throw new System.NotImplementedException();
        }
    }
}
