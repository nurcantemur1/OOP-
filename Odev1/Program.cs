namespace Odev1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer = new Gamer();
            Console.WriteLine("Adınız :");
            gamer.Ad = Console.ReadLine();
            Console.WriteLine("Soyad :");
            gamer.Soyad = Console.ReadLine();
            Console.WriteLine("DogumYili :");
            gamer.DogumYili= Console.ReadLine();
            Console.WriteLine("TcNo :");
            gamer.TcNo= Console.ReadLine(); 

            GamerManager gamerManager = new GamerManager();
            gamerManager.Add(gamer);
            gamerManager.Update(gamer);
            gamerManager.Delete(gamer);





            Console.ReadLine();
        }
    }
}