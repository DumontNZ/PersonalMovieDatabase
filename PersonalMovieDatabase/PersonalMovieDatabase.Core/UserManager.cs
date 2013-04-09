using Ninject.Extensions.Logging;
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
            throw new System.NotImplementedException();
        }
    }
}
