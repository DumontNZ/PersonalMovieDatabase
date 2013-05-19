using NUnit.Framework;
using PersonalMovieDatabase.Common.Cryptography;

namespace PersonalMovieDatabase.Common.Tests
{
    [TestFixture]
    public class CryptographyTests
    {
        private readonly ICryptography _cryptography;
        private const string Password = "Password1";
        private readonly string _salt;
        private string _hashedPassword; 

        public CryptographyTests()
        {
            _cryptography = new Cryptography.Cryptography();
            _salt = _cryptography.GeneratePasswordSalt(); 
        }

        [Test]
        public void SuccessfullyGenerateHashedPassword()
        {
            _hashedPassword = _cryptography.HashPassword(Password, _salt);
            Assert.False(string.Equals(_hashedPassword, Password));
        }

        [Test]
        public void SuccessfullyValidatePassword()
        {
            Assert.True(_cryptography.ValidatePassword(Password, _salt, _hashedPassword));
        }
    }
}
