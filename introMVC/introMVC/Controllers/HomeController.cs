using introMVC.Models;
using introMVC.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace introMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            //setting:
            ViewBag.Ad = "Türkay";
            ViewBag.Items = new List<string>() { "A", "B", "C" };
            var products = new List<Product>
            {
                new Product{ Id = 1, Name="Ürün A", Price=5, Description="Ürün A Açıklama"},
                new Product{ Id = 2, Name="Ürün B", Price=15, Description="Ürün B Açıklama"},
                new Product{ Id = 3, Name="Ürün C", Price=5, Description="Ürün C Açıklama"}
            };

            return View(products);
        }

        public ActionResult About()
        {
            var model = new AboutViewModel { Title = "Hakkımdaki dedikodular" };
            return View(model);
        }
    }
}