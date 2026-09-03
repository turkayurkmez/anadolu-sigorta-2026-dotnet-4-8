using ECommerceSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ECommerceSample.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product) {

            if (ModelState.IsValid)
            {
                //db'ye ekle ve eklendi diye mesaj gönder.

            }

            return View(ModelState);


        }
    }
}