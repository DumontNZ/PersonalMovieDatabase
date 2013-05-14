using System.Collections.Generic;
using PersonalMovieDatabase.Domain;

namespace PersonalMovieDatabase.Repository
{
    public interface IUserRepository
    {
        /// <summary>
        /// Creates the user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        int CreateUser(User user);

        /// <summary>
        /// Gets all users.
        /// </summary>
        /// <returns></returns>
        IEnumerable<User> GetAllUsers();

        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns></returns>
        User GetUser(int userId);

        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        User GetUser(User user);

        /// <summary>
        /// Updates the user.
        /// </summary>
        /// <param name="userId">The user id.</param>
        /// <returns></returns>
        User UpdateUser(int userId);

        /// <summary>
        /// Updates the user.
        /// </summary>
        /// <param name="user">The user.</param>
        /// <returns></returns>
        User UpdateUser(User user);

        /// <summary>
        /// Deletes the user.
        /// </summary>
        /// <param name="userId">The user id.</param>
        void DeleteUser(int userId);

        /// <summary>
        /// Deleteusers the specified user.
        /// </summary>
        /// <param name="user">The user.</param>
        void Deleteuser(User user);
    }
}
