namespace OOP2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager<Coorporate> customerManager = new CustomerManager<Coorporate>();
            customerManager.Add(new Coorporate 
            { Id=1,CustomerNo=2,Name="gg",VergiNo=2});
            Console.WriteLine("Hello, World!");
        }
    }
}