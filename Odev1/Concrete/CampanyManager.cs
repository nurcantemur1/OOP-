using Odev1.Abstruct;
using Odev1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1.Concrete
{
    class CampanyManager : ICampanyService
    {
        public void Add(Campany campany)
        {
            Console.WriteLine(campany.Name);
        }

        public void Delete(Campany campany)
        {
            throw new NotImplementedException();
        }

        public void Update(Campany campany)
        {
            throw new NotImplementedException();
        }
    }
}
