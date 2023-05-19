namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*  KonutCrediManager konutCrediManager = new KonutCrediManager();
              konutCrediManager.konuticinhesapla();

              TasitCrediManager tasitCrediManager = new TasitCrediManager();
              tasitCrediManager.tasıticinhesapla();
            */

            KonutCrediManager konutCrediManager = new KonutCrediManager();
            TasitCrediManager tasitCrediManager = new TasitCrediManager();
            BasvuruManager basvuruManager = new BasvuruManager();
           // basvuruManager.basvuruyap(crediManager: konutCrediManager);
          

            List<ICredi> credis = new List<ICredi>();
            credis.Add(tasitCrediManager);
            credis.Add(konutCrediManager);

            basvuruManager.bilgilendirme(credis);














            Console.ReadLine();
        }
    }
}