using System;
using System.Web.Mvc;
using Ninject.Extensions.Logging;
using PersonalMovieDatabase.Common.Configuration;
using PersonalMovieDatabase.Core;

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
            _logger.Info("Inside logon");
            string something = _config.SomethingImportant; 
            _userManager.Testin();
            return View();
        }

        public ActionResult CreateAccount()
        {


            throw new NotImplementedException();
            //return View(); 
        }

    }
}
