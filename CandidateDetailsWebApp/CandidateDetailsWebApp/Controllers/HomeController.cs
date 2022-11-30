using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CandidateDetailsWebApp.Models;

namespace CandidateDetailsWebApp.Controllers
{
    public class HomeController : Controller
    {
        CandidateDBContext db = new CandidateDBContext();

        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(Candidate c)
        {
            db.candidates.Add(c);
            db.SaveChanges();
            return View();
        }
    }
}