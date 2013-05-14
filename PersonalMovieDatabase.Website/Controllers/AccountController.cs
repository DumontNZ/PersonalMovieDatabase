using System;
using System.Web.Mvc;
using Ninject.Extensions.Logging;
using PersonalMovieDatabase.Common.Configuration;
using PersonalMovieDatabase.Common.Resources;
using PersonalMovieDatabase.Core;
using PersonalMovieDatabase.Domain;
using PersonalMovieDatabase.Website.Models;

namespace PersonalMovieDatabase.Website.Controllers
{
    public class AccountController : Controller
    {
        private readonly IUserManager _userManager;
        private readonly IConfig _config;
        private readonly ILogger _logger;

        public AccountController(IUserManager userManager, IConfig config, ILogger logger)
        {
            _userManager = userManager;
            _config = config;
            _logger = logger;
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
                if (!userModel.Password.Equals(userModel.ReenterPassword))
                {
                    ModelState.AddModelError("Password", ErrorMessages.PasswordsDoNotMatch);
                }

                //if (_userManager.GetUser("Username" != null))
                //{
                //    ModelState.AddModelError("Username", ErrorMessages.UsernameInUse);
                //}

                if (ModelState.IsValid)
                {
                    _userManager.CreateUser(new User
                         {
                             UserName = userModel.Username,
                             FirstName = userModel.FirstName,
                             Surname = userModel.Surname,
                             Country = userModel.Country,
                             Email = userModel.EmailAddress,
                             Password = userModel.Password,
                         });

                    return View("Logon");

                }
            }

            return View(userModel);
        }


    }
}
