using System;
using System.Web.Mvc;
using Ninject.Extensions.Logging;
using PersonalMovieDatabase.Common.Configuration;
using PersonalMovieDatabase.Common.Cryptography;
using PersonalMovieDatabase.Common.Resources;
using PersonalMovieDatabase.Core;
using PersonalMovieDatabase.Domain;
using PersonalMovieDatabase.Website.Mailers;
using PersonalMovieDatabase.Website.Models;

namespace PersonalMovieDatabase.Website.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserManager _userManager;
        private readonly IConfig _config;
        private readonly ILogger _logger;
        private readonly ICryptography _cryptography; 
        private IUserMailer _userMailer = new UserMailer();

        public IUserMailer UserMailer
        {
            get { return _userMailer; }
            set { _userMailer = value; }
        }


        public AccountController(IUserManager userManager, IConfig config, ILogger logger, ICryptography cryptography)
        {
            _userManager = userManager;
            _config = config;
            _logger = logger;
            _cryptography = cryptography; 
        }

        public ActionResult Logon()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Logon(UserModel userModel)
        {


            throw new NotImplementedException();
        }

        public ActionResult CreateAccount()
        {


            return View();
        }

        [HttpPost]
        public ActionResult CreateAccount(UserModel userModel)
        {
            if (ModelState.IsValid)
            {
                //if (_userManager.GetUser("Username" != null))
                //{
                //    ModelState.AddModelError("Username", ErrorMessages.UsernameInUse);
                //}

                if (ModelState.IsValid)
                {
                    string passwordSalt = _cryptography.GeneratePasswordSalt();
 
                    var user = new User
                        {
                            UserName = userModel.Username,
                            FirstName = userModel.FirstName,
                            Surname = userModel.Surname,
                            Country = userModel.Country,
                            Email = userModel.EmailAddress,
                            PasswordSalt = passwordSalt,
                            Password = _cryptography.HashPassword(userModel.Password, passwordSalt)
                        };

                    _userManager.CreateUser(user);

                    UserMailer.Welcome(user).Send();

                    return View("Logon");
                }
            }

            return View(userModel);
        }
    }
}
