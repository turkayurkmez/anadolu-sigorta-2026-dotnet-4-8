using ECommerceSample.Models;
using ECommerceSample.Services;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

using System.Web.Http;
using System.Web.Http.Results;
using System.Web.Mvc;
using System.Web.Services.Protocols;

namespace ECommerceSample.Controllers
{
    public class ProductsApiController : ApiController
    {
        
        /*
         * Artık istemci (JQuery, React ya da Angular) ile bu API'yi consume edebilir.
         */
        public IEnumerable<Product> Get()
        {
            var productService = new ProductService();
            var products = productService.GetProducts();
            return products;
        }

        public Product Get(int id)
        {
            
            var product = new ProductService().GetProduct(id);
            return product;
        }

        public void Post(Product product)
        {
            var service = new ProductService();
            service.Create(product);


        }

      
    }
}
