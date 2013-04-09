using System;
using System.Collections.Generic;
using PersonalMovieDatabase.Domain;

namespace PersonalMovieDatabase.Repository
{
    public class UsersRepository : IUsersRepository
    {
        public Users CreateUser(Users user)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Users> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Users GetUser(int userId)
        {
            throw new NotImplementedException();
        }

        public Users GetUser(string username)
        {
            throw new NotImplementedException();
        }

        public void DeleteUser(int userId)
        {
            throw new NotImplementedException();
        }

        public void Deleteuser(string username)
        {
            throw new NotImplementedException();
        }
    }
}
