using System;
using System.Linq;
using NUnit.Framework;
using System.Collections.Generic;
using PersonalMovieDatabase.Common.Cryptography;
using PersonalMovieDatabase.Domain; 

namespace PersonalMovieDatabase.Repository.Tests
{
    [TestFixture]
    public class UserRepositoryTest : TestBase
    {
        private readonly ICryptography _cryptography;
        private const string Password = "Password";
        public UserRepositoryTest()
        {
            _cryptography = new Cryptography();
        }

        [Test]
        public void RetrieveAllUsersSuccessful()
        {
            var userRepository = new UserRepository();
            IEnumerable<User> users = userRepository.GetAllUsers();

            Assert.IsTrue(users.Any());
        }

        [Test]
        public void SuccessfullyCreateUser()
        {
            var userRepository = new UserRepository();
            string passwordSalt = _cryptography.GeneratePasswordSalt(); 
            var user = new User
                {
                    UserName = Guid.NewGuid().ToString(),
                    Email = "NewUser@NewUser.com",
                    FirstName = "Frank",
                    Surname = "TheTank",
                    Country = "Australia",
                    PasswordSalt = passwordSalt, 
                    Password = _cryptography.HashPassword(Password, passwordSalt)
                };

            var isSucessful = userRepository.CreateUser(user);

            Assert.IsTrue(isSucessful > 0);
        }
    }
}
