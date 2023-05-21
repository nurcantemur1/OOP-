using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Odev1.Abstruct;
using Odev1.Entities;

namespace Odev1.Concrete
{
    class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine(gamer.Ad);
        }

        public void Delete(Gamer gamer)
        {   
            Console.WriteLine(gamer.Ad+" silme başarılı");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.Ad+" güncelleme başarılı");
        }
        public void GamerSalary(Gamer gamer)
        {
            Console.WriteLine(gamer.Ad+" kullanıcısına oyun satıldı");
        }

    }
}
