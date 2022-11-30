using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using DataDisplay.Models;

namespace DataDisplay.Controllers
{
    public class HomeController : Controller
    {
        BusDBEntities db = new BusDBEntities();
        // GET: Home
        public ActionResult DataDisplay()
        {
            var data = db.BusInfoes.ToList();
            return View();
        }
    }
}