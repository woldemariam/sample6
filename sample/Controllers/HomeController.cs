using sample.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            //using (Entities e = new Entities())
            //{
            //    var item = e.Englishes.First();
            //    ViewBag.Message = item.Term;

            //}

            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
