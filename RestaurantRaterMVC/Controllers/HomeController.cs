using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RestaurantRaterMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "What is Restaurant Rater All About?";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Don't worry, we love getting your messages!";

            return View();
        }
        public ActionResult Gallery()
        {
            ViewBag.Message = "Image Gallery";

            return View();
        }
        public ActionResult Team()
        {
            ViewBag.Message = "Our Team";

            return View();
        }
    }
}