using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsInPro
{
    class Dictionaries
    {
        public void Add(int key , string value) 
        {
            Dictionary<int,string> neww = new Dictionary<int, string>();
            neww.Add(key,value);
            foreach (var item in neww)
            {
                Console.WriteLine(item.Key+" "+item.Value+" eklendi");
            }
        }
        

    }
}
