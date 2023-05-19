namespace deneme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            string a;

            List<string> strings = new List<string>();
            for (int i = 0; i < 4; i++)
            {
               a = Console.ReadLine();
                strings.Add(a);
            }
            Manager manager = new Manager();
            manager.yaz(strings);

            Console.ReadLine();
        }
    }
}