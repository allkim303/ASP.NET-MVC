using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment2.Controllers
{
    public class HomeController : Controller
    {
        // Reference to the data manager
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Assignment";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Seneca@York Campus.";

            return View();
        }
    }
}