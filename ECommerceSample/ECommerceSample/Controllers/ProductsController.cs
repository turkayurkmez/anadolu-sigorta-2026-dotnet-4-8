using ECommerceSample.Models;
using ECommerceSample.Services;
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
            using (var productService = new ProductService())
            {
                var products = productService.GetProducts();
                return View(products);
            }

        }

        [HttpGet]
        [Authorize]
        public ActionResult Create()
        {
            return View();
        }

        [Authorize]
        [HttpPost]
        public ActionResult Create(Product product)
        {

            if (ModelState.IsValid)
            {
                //db'ye ekle ve eklendi diye mesaj gönder.
                var productService = new ProductService();
                productService.Create(product);
                return RedirectToAction(nameof(Index));
            }

            return View(product);


        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var productService = new ProductService();
            var product = productService.GetProduct(id);
            if (product is null)
            {
                return HttpNotFound($"{id} id'li ürün bulunamadı");
            }
            return View(product);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            if (ModelState.IsValid)
            {
                var productService = new ProductService();
                productService.Update(product);

                TempData["durum"] = "Ürün başarıyla güncellendi";

                return RedirectToAction(nameof(Index));
            }
            return View(product);
        }

        public ActionResult Delete(int id)
        {
            var productService = new ProductService();
            var product = productService.GetProduct(id);
            if (product is null)
            {
                return HttpNotFound("Bu id'de bir ürün yok");
            }

            return View(product);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            var service = new ProductService();
            service.Delete(id);
            TempData["durum"] = "Ürün başarıyla silindi";
            return RedirectToAction("Index");
        }
    }
}