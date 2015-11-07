using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Charpter01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = Product.GetSampleProducts();
            var result = from Product p in products
                         where p.Price > 11.00m
                         select p;

            foreach(Product p in result)
            {
                Console.WriteLine(p);
            }

            Console.Read();
        }
    }

    class Product
    {
        public string Name { get; private set; }
        public decimal Price { get; private set; }

        public Product(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public Product() { }

        public static List<Product> GetSampleProducts()
        {
            return new List<Product>()
            {
                new Product("B", 10.99m)
                , new Product("A", 20.99m)
                , new Product("C", 30.99m)
            };
        }

        public static ArrayList GetSampleArrayProducts()
        {
            return new ArrayList()
            {
                new Product("B", 10.99m)
                , new Product("A", 20.99m)
                , new Product("C", 30.99m)
            };
        }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Name, Price);
        }
    }
}
