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
            DatabaseLoggerService databaseLoggerService = new DatabaseLoggerService();  
            SMSLoggerService smsLoggerService = new SMSLoggerService();
           // FileLoggerService fileLoggerService = new FileLoggerService();  


            KonutCrediManager konutCrediManager = new KonutCrediManager();
            TasitCrediManager tasitCrediManager = new TasitCrediManager();


            BasvuruManager basvuruManager = new BasvuruManager();
          //  basvuruManager.basvuruyap(crediManager: konutCrediManager,databaseLoggerService );
          

            List<ICredi> credis = new List<ICredi>();
            credis.Add(tasitCrediManager);
            credis.Add(konutCrediManager);

         /*   List<ILoggerService> loggerServices = new List<ILoggerService>();   
            loggerServices.Add(smsLoggerService);
            loggerServices.Add(databaseLoggerService);
         */
            //  basvuruManager.bilgilendirme(credis,new FileLoggerService());

            basvuruManager.cokluloglama(credis,new List<ILoggerService> { new SMSLoggerService(),new DatabaseLoggerService()});
            basvuruManager.coklulog(new TasitCrediManager(),new List<ILoggerService> {new FileLoggerService(),new SMSLoggerService()});








            Console.ReadLine();
        }
    }
}