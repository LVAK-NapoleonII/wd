using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace wedfilm.Controllers
{
    public class wedfilmController : Controller
    {
        // GET: wedfilm
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult menu()
        {
            return View();
        }
        public ActionResult login()
        {
            return View();
        }
        public ActionResult GENRE()
        {
            return View();
        }
        public ActionResult MOVIES()
        {
            return View();
        }
        public ActionResult SERIES()
        {
            return View();
        }
        public ActionResult ABOUT()
        {
            return View();
        }

    }
}