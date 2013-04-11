using System.Collections.Generic;
using Ninject.Extensions.Logging;
using PersonalMovieDatabase.Domain;
using PersonalMovieDatabase.Repository;

namespace PersonalMovieDatabase.Core
{
    public class UserManager : IUserManager
    {
        private readonly IUsersRepository _usersRepository;
        private readonly ILogger _logger;

        public UserManager(IUsersRepository usersRepository, ILogger logger)
        {
            _usersRepository = usersRepository;
            _logger = logger;
        }

        public void Testin()
        {
            _logger.Debug("Inside Manager");
            IEnumerable<Users> users = _usersRepository.GetAllUsers();
            throw new System.NotImplementedException();
        }
    }
}
