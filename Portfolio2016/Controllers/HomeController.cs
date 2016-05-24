using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio2016.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //return View(); My working index is really in ProjectListModels
            return RedirectToAction("Index", "ProjectListModels");
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}