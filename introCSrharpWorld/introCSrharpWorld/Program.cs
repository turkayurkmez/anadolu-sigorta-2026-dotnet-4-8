using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace introCSrharpWorld
{
    internal class Program
    {


        static void Main(string[] args)
        {
            var x = 5;
            //int x = 5;
            var isSuccess = true;

            var nothingObject = new { Ad = "Türkay", Puan = x };
            // nothingObject.

            var products = new List<Product>();
            products.Add(
                new Product { Id = 1, Description = "Sample D.", Name = "Sample 1" }
            );

            products.Add(
             new Product { Id = 2, Description = "Sample D2.", Name = "Z" }
         );
            products.Add(
             new Product { Id = 3, Description = "Sample D3.", Name = "A" }
         );


            var hi = "selam";

            var anonymResult = from p in products
                               where p.Id > 1
                               select new { p.Id, p.Name }; //SELECT Id, Name FROM Products


            Process.ShowNumbers();

            string name = "mehmet ali erbil";

            Console.WriteLine(name.ToTitleCase());

            var productResult = products.Where(p => p.Id >= 2).OrderBy(p => p.Name).ToList();
            productResult.ForEach(p => Console.WriteLine(p.Name));

            if (DateTime.Now.IsWeekend())
            {
                Console.WriteLine("İyi tatiller :)");
            }
            else
            {
                Console.WriteLine("İyi çalışmalar :(");

            }
        }
    }
}
