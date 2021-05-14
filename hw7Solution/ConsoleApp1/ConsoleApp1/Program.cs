using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public class Product
    {
        public static List<Product> Products = new List<Product>();
        private string name;
        private decimal price;
        public string Name{ get => name; set => name = value; }
        public decimal Price{ get => price; set => price = value; }
        public Product(string name, decimal price)
        {
            this.name = name;
            this.price = price;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            #region objects
            Product.Products.Add(new Product("Phone", 2000));
            Product.Products.Add(new Product("Printer", 1000));
            Product.Products.Add(new Product("Car", 6000));
            Product.Products.Add(new Product("Toaster", 4000));
            Product.Products.Add(new Product("Laptop", 1000));
            Product.Products.Add(new Product("Computer", 4000));
            #endregion
            var StartsWithP = (from y in Product.Products
                              where y.Name[0] == 'P'
                              select y.Price).Sum();
            var HigherThan = Product.Products.Where(y => y.Price > 1000).ToList();

            var GroupByPrice = from y in Product.Products
                               group (y.Name, y.Price) by y.Price;
            var OrderByPrice = Product.Products.OrderBy(y => y.Price).ToList();

            Console.WriteLine($"sum of all products prices that start with P:{StartsWithP}\n");
            Console.WriteLine("list of all products with price higher than 1000:");
            foreach (var item in HigherThan)
            {
                Console.WriteLine(item.Name + " " + item.Price);
            }

            Console.WriteLine("\ngrouped by price:");
            foreach (var item in GroupByPrice)
            {
                foreach (var item2 in item)
                {
                    Console.WriteLine(item2);
                }
            }

            Console.WriteLine("\nordered by price:");
            foreach (var item in OrderByPrice)
            {
                Console.WriteLine(item.Name + " " + item.Price);
            }

        }
    }
}

