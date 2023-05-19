using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    class CustomerManager<T>
    {
        public CustomerManager() { }    
        public void Add(T item) 
        {
            List<T> values = new List<T>();
            values.Add(item);
            
            foreach (T value in values) 
            {
            Console.WriteLine(value+" eklendi");
            }
        }  
        public void adde(Coorporate coorporate) 
        {
            List<Coorporate> values = new List<Coorporate>();
            
            values.Add(coorporate);
            
            foreach (var value in values)
            {   
                Console.WriteLine(value.Id + " eklendi");
            }
        }
    }
}
