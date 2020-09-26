using System;
using System.Collections.Generic;
using System.Linq;

namespace Ntt_Frmwrk_Cr.v2
{
    class Program
    {
        static void Main(string[] args)
        {
            using(AppContext db = new AppContext())
            {
                //Product product1 = new Product { Name = "Cheese", Price = 63 };
                //Product product2 = new Product { Name = "Beer", Price = 16 };

                //db.Products.AddRange(product1, product2);
                //db.SaveChanges();

                var users = db.Products.ToList();

                ConsoleColor color = Console.ForegroundColor;
                Console.ForegroundColor = ConsoleColor.DarkGreen;

                foreach (Product u in users)
                {
                    Console.WriteLine($"{u.Id}.{u.Name} - {u.Price}");
                }

                Console.ForegroundColor = color;
            }
        }
    }
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public Company Manufacturer { get; set; }
    }
    public class Company
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Country
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
