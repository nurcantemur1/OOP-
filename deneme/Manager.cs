using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    class Manager : IManager
    {
        public void yaz(List<string> strings)
        {
            foreach (string s in strings) { Console.WriteLine(s+" "); }
        }
    }
}
