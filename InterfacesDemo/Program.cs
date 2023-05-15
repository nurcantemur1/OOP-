using System;

namespace InterfacesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            






            Console.ReadLine();
        }

    }


    class Customer
    {
        public Customer()//default constructor
        {
            Console.WriteLine("constructor");
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
}
