using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqProject
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Category> categories = new List<Category>()
            { 
                new Category{CategoryId=1,CategoryName="Bilgisayar"},
                new Category{CategoryId=2,CategoryName="Telefon"},
                new Category{ CategoryId=3,CategoryName="Tablet"}
            };

            foreach (var item in categories)
            {
               // Console.WriteLine(item.CategoryName);
            }

            List<Product> products = new List<Product>()
            {
               new Product{ProductId=1,CategoryId=2,ProductName="ab1",QuantityPerUnit="hh",UnitPrice=3,UnitsInStok=6},
               new Product{ProductId=2,CategoryId=1,ProductName="AB2",QuantityPerUnit="aa",UnitPrice=10,UnitsInStok=1},
               new Product{ProductId=3,CategoryId=3,ProductName="ab3",QuantityPerUnit="bb",UnitPrice=30,UnitsInStok=4},
               new Product{ProductId=4,CategoryId=1,ProductName="ab4",QuantityPerUnit="cc",UnitPrice=100,UnitsInStok=3}
            };
            Console.WriteLine("Algoritmik------");
            foreach (var item in products)
            {
                if (item.UnitPrice>5)
                {
                    Console.WriteLine(item.ProductName);
                }
            }
            int sayac = 0;
            for (int i = 0; i < products.Count; i++)
            {
                sayac = sayac + 1;
                
            }
            Console.WriteLine(sayac);

            Console.WriteLine("Linq--------");

            var result = products.Where(products=>products.UnitPrice>5);
            foreach (var item in result)
            {
                Console.WriteLine(item.ProductName);
            }

            GetProducts(products);//algoritmik
            GetProduct(products);//linq

            Console.ReadLine();
        }
       static List<Product> GetProducts(List<Product> products ) 
       {
            List<Product> filterproducts = new List<Product>();
            foreach (var item in products)
            {
                if (item.UnitPrice > 5)
                {
                    filterproducts.Add(item);
                    Console.WriteLine(item.ProductName);
                }
            }
            return filterproducts;
        }
        static List<Product> GetProduct(List<Product> products)
        {
            return products.Where(products => products.UnitPrice > 5).ToList();
        }

    }


    class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; } 
        public decimal UnitPrice { get; set; }
        public int UnitsInStok { get; set; }
    }

    class Category
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
