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
            this.Configuration.LazyLoadingEnabled = false;
            //Dikkat: Web API içerisinde EF tarafından üretilen Dynamic Proxies serialize edilemeyeceği için Dynamic Proxy üretimini kapattık:
            this.Configuration.ProxyCreationEnabled = false; 
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Product>().HasOptional(p => p.Category);

            modelBuilder.Entity<Category>().HasMany(c => c.Products)
                                           .WithOptional(p => p.Category)
                                           .HasForeignKey(p => p.CategoryId)
                                           .WillCascadeOnDelete(false);

        }
    }
}