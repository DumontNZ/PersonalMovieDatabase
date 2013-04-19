using System.Collections.Generic;
using PersonalMovieDatabase.Domain;

namespace PersonalMovieDatabase.Repository
{
    public interface IUserRepository
    {
        User CreateUser(User user);
        IEnumerable<User> GetAllUsers();
        User GetUser(int userId);
        User GetUser(string username);
        void DeleteUser(int userId);
        void Deleteuser(string username);
    }
}
