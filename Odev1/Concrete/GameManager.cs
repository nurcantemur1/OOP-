using Odev1.Abstruct;
using Odev1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1.Concrete
{
    class GameManager : IGameService
    {
        public void Add(Game game)
        {
            Console.WriteLine(game.Name+ " eklendi");
        }
        public void Delete(Game game)
        {
            throw new NotImplementedException();
        }

        public void Sale(Game game, Gamer gamer, Campany campany)
        {
            Console.WriteLine(game.Name+" oyununa "+gamer.Ad+" kullanıcısı "+campany.Name+ " kampanyası uyguladı");
        }
        public void Update(Game game)
        {
            throw new NotImplementedException();
        }
    }
}
