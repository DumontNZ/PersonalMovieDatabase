using System.Collections.Generic;
using PersonalMovieDatabase.Domain;

namespace PersonalMovieDatabase.Core
{
    public interface IUserManager
    {
        /// <summary>
        /// Creates the user.
        /// </summary>
        /// <returns></returns>
        int CreateUser(User user);

        /// <summary>
        /// Gets all users.
        /// </summary>
        /// <returns></returns>
        IEnumerable<User> GetAllUsers();
    }
}
