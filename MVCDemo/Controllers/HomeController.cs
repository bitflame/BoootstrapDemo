using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult AboutMe()
        {
            ViewBag.Message = "This page is meant to provide some information about my professional skills, " +
                "interests, and activities.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "MY contact Information:";

            return View();
        }
    }
}