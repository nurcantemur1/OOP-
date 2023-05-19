using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1
{
    class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {
            Console.WriteLine("kayıt başarılı");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("silme başarılı");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("güncelleme başarılı");
        }
    }
}
