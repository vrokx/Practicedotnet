using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment2.Models;
using static System.Net.WebRequestMethods;

namespace Assignment2.Controllers
{
    public class HomeController : Controller
    {
        BusDBEntities1 db =  new BusDBEntities1();
        // GET: Home
        public ActionResult AddBusData()
        {
            return View();
        }
    }
}