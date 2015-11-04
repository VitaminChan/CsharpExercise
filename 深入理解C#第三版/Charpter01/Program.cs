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
            // 條件: 找出價格大於10的並打印出來
            List<Product> products = Product.GetSampleProducts();
            products.FindAll(delegate(Product p) { return p.Price > 11.00m; }).ForEach(Console.WriteLine);
            Console.Read();
        }
    }

    class ProductNameComparer : IComparer<Product>
    {
        public int Compare(Product x, Product y)
        {
            Product first = x;
            Product second = y;
            return first.Name.CompareTo(second.Name);
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
