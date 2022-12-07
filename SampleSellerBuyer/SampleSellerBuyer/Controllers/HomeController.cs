using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SampleSellerBuyer.Models;

namespace SampleSellerBuyer.Controllers
{
    public class HomeController : Controller
    {
        ProductDBContext db = new ProductDBContext();
        // GET: Home
        [HttpGet]
        public ActionResult Index()
        {
            var data = db.Products.ToList();
            return View(data);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(ProductModel model)
        {
            db.Products.Add(model);
            db.SaveChanges();
            return View();
        }
    }
}