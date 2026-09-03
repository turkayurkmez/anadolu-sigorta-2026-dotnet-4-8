namespace ECommerceSample.Migrations
{
    using ECommerceSample.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<ECommerceSample.Data.CatalogDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(ECommerceSample.Data.CatalogDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.


            context.Categories.AddOrUpdate(
                 new Category {  Id =1, Name ="Elektronik", Description="Bilgisayar ve ev elektroniği"},
                 new Category { Id = 2, Name = "Giyim", Description = "Kadın ve erkek her mevsim için..." }

                );

            context.Products.AddOrUpdate(
                new Product { Id=1, Name = "Ürün A", Price = 10, StockCount = 100, CategoryId=1 },
                new Product { Id=2, Name = "Ürün B", Price = 50, StockCount = 100, CategoryId=2 },
                new Product { Id=3, Name = "Ürün C", Price = 100, StockCount = 100, CategoryId=1 }

            );


        }
    }
}
