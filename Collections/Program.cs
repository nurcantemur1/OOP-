using System.Collections.Generic;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //Dizi();
            List<string> strings = new List<string>() { "a", "b", "c", "d" };
            strings.Add("hhhhhhhhhhhhh");

            int sayac=1;
            foreach (string item in strings)
            {
                sayac++;
                if (strings.Contains("b"))//içerme arama fonk kullanılır
                {
                    Console.WriteLine("bulundu "+ sayac+". adımda ");
                    break;
                }
            }


            foreach (string s in strings) { Console.WriteLine(s); }
            Console.ReadLine();
        }

        private static void Dizi()
        {
            string[] abc = new string[] { "a", "b", "c", "d" };

            foreach (string abc2 in abc)
            {

                Console.WriteLine(abc2);
            }
        }
    }
}