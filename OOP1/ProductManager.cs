using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    class ProductManager
    {
        public void Add(Product product) 
        {
            Console.WriteLine(product.ProductName);
            
        }
        public void Update() 
        {
            Console.WriteLine("guncellendi");
        }
        public void Delete() 
        {

        }
        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }
      
    }
}
