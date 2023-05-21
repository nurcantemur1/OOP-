using Odev1.Concrete;
using Odev1.Entities;

namespace Odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Gamer gamer = GamerMethod();

            Game game = new Game();
            game.Id = 1;
            game.Name = "test";

            Campany campany = new Campany();
            campany.Id = 1;
            campany.Name = "test";

            Gamer gamer = new Gamer();
            gamer.Ad = "test";
            gamer.Soyad = gamer.Ad;
            gamer.DogumYili = gamer.Ad;
            gamer.TcNo = gamer.Ad;

            GameManager gameManager = new GameManager();

           // gameManager.Add(game);
            gameManager.Sale(game, gamer, campany);


            Console.ReadLine();
        }

        private static Gamer GamerMethod()
        {
            Gamer gamer = new Gamer();
            Console.WriteLine("Adınız :");
            gamer.Ad = Console.ReadLine();
            Console.WriteLine("Soyad :");
            gamer.Soyad = Console.ReadLine();
            Console.WriteLine("DogumYili :");
            gamer.DogumYili = Console.ReadLine();
            Console.WriteLine("TcNo :");
            gamer.TcNo = Console.ReadLine();

            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer);
            gamerManager.Update(gamer);
            gamerManager.Delete(gamer);
            return gamer;
        }
    }
}