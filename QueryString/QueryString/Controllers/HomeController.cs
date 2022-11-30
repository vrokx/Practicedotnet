using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QueryString.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string name, int? num)
        {
            ViewBag.Name = name;
            ViewBag.Num = num;
            return View();
        }
    }
}