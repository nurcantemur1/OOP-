using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Sql : ICustomerDal
    {
        public void Add()
        {
            Console.WriteLine(" Sql'e eklendi");
        }
        public void Delete()
        {
            throw new NotImplementedException();
        }
        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
