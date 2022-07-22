using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TCWebApp.Models;

namespace TCWebApp.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login()
        {        
            return View();
        }

        [HttpPost]
        public ActionResult Login(UserData User)
        {
            Session["UserName"] = User.UserName.ToString();

            return RedirectToAction("Flyer");
        }

        public ActionResult Flyer()
        {
            return View();
        }
    }
}