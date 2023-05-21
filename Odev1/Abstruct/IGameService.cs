using Odev1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev1.Abstruct
{
    interface IGameService
    {
        void Sale(Game game,Gamer gamer,Campany campany);
        void Add(Game game);
        void Delete(Game game);
        void Update(Game game);
        
    }
}
