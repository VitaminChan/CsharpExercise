using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Charpter01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = Product.GetSampleProducts();

            //products.Sort( (x,y) => x.Name.CompareTo(y.Name));

            foreach (Product product in products.OrderBy(p => p.Name))
            {
                Console.WriteLine(product);
            }
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

        public override string ToString()
        {
            return string.Format("{0}: {1}", Name, Price);
        }
    }
}
