using Ninject.Extensions.Logging;
using PersonalMovieDatabase.Domain;

namespace PersonalMovieDatabase.Core
{
    public class NotificationManager
    {
        private ILogger _logger;

        public NotificationManager(ILogger logger)
        {
            _logger = logger;
        }

        public void ConfirmationEmail(User user)
        {

        }
    }
}
