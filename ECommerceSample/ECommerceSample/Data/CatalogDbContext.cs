using ECommerceSample.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ECommerceSample.Data
{
    public class CatalogDbContext : DbContext
    {
        public CatalogDbContext() : base("CatalogConnection")
        {
                
        }

        public DbSet<Product> Products { get; set; }

    }
}