using System.Linq;
using System.Transactions;
using NUnit.Framework;
using System.Collections.Generic;
using PersonalMovieDatabase.Domain; 

namespace PersonalMovieDatabase.Repository.Tests
{
    [TestFixture]
    public class UserRepositoryTest : TestBase
    {

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

            var user = new User
                {
                    UserName = "NewUser",
                    Email = "NewUser@NewUser.com",
                    FirstName = "Frank",
                    Surname = "TheTank",
                    Country = "Australia",
                    Password = "Password1"
                };

            var isSucessful = userRepository.CreateUser(user);

            Assert.IsTrue(isSucessful > 0);
        }
    }
}
