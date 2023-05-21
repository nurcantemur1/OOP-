using Odev1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1.Abstruct
{
    interface ICampanyService
    {
        void Add(Campany campany);
        void Delete(Campany campany);
        void Update(Campany campany);
    }
}
