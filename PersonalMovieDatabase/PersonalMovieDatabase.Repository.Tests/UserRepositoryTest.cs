using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using PersonalMovieDatabase.Domain; 

namespace PersonalMovieDatabase.Repository.Tests
{
    [TestFixture]
    public class UserRepositoryTest
    {
        [Test]
        public void TestDatabaseConnection()
        {
            UserRepository userRepository = new UserRepository();
            IEnumerable<User> users = userRepository.GetAllUsers();

            Assert.IsTrue(users.Any());
        }
    }
}
