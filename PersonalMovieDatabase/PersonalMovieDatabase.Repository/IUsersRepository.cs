using System.Collections.Generic;
using PersonalMovieDatabase.Domain;

namespace PersonalMovieDatabase.Repository
{
    public interface IUsersRepository
    {
        Users CreateUser(Users user);
        IEnumerable<Users> GetAllUsers();
        Users GetUser(int userId);
        Users GetUser(string username);
        void DeleteUser(int userId);
        void Deleteuser(string username);
    }
}
