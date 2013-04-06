using System;
using System.Web.Mvc;

namespace PersonalMovieDatabase.Website.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/

        public ActionResult Logon()
        {
            return View();
        }

        public ActionResult CreateAccount()
        {
            throw new NotImplementedException();
            //return View(); 
        }

    }
}
