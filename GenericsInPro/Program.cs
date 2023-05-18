namespace GenericsInPro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            MyList<string> myList = new MyList<string>();

            myList.Add("ggggggggg");
            myList.lenght();
            myList.Add("fkmb");
            myList.lenght();
            myList.Add("jjjjjjj");
            myList.lenght();

            Dictionary<int,string> myDictionary = new Dictionary<int, string>();
            myDictionary.Add(0,"vfvf");
            myDictionary.Add(1, "aa");
            foreach (var item in myDictionary) { Console.WriteLine(item.Key+" "+item.Value); }

            SortedList<int,string> deneme = new SortedList<int,string>();
            deneme.Add(4,"vfşçv");
            deneme.Add(2,"i.cid");
            deneme.Add(1,"vvv");
            foreach (var item in deneme)
            {
                Console.WriteLine(item.Key+" "+item.Value);
            }

            Console.ReadLine();
        }
    }
}