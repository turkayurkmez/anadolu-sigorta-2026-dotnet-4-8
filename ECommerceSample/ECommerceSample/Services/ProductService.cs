using ECommerceSample.Data;
using ECommerceSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ECommerceSample.Services
{
    public class ProductService : IDisposable
    {
        private CatalogDbContext dbContext;

        public ProductService()
        {
            dbContext = new CatalogDbContext();
        }
        public IEnumerable<Product> GetProducts()
        {
            return dbContext.Products.ToList();
        }

        public Product GetProduct(int id)
        {
            return dbContext.Products.FirstOrDefault(p => p.Id == id);
        }

        public void Create(Product product)
        {
            dbContext.Products.Add(product);
            dbContext.SaveChanges();
        }

        public void Update(Product product)
        {
            dbContext.Entry(product).State = System.Data.Entity.EntityState.Modified;
            dbContext.SaveChanges();
        }
        
        public void Delete(int id)
        {
            var product = dbContext.Products.Find(id);
            dbContext.Products.Remove(product);
            dbContext.SaveChanges();
        }


        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}