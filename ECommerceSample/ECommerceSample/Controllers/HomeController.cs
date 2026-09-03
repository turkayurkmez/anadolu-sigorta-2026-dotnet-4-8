using ECommerceSample.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceSample.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var db = new CatalogDbContext())
            {
                var allProducts = db.Products.OrderBy(p => p.Price).ToList();
                return View(allProducts);
            }
           
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