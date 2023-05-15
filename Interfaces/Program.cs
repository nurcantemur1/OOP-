using System;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Console.WriteLine("Hello World!");

            //  Interfaces();
            //Demo();

          //  veritabanlarınaekleme();















            Console.ReadLine();
        }

        private static void veritabanlarınaekleme()
        {
            ICustomerDal[] customerDals = new ICustomerDal[] { new Oracle(), new Sql() };

            foreach (var item in customerDals)
            {
                item.Add();
            }
        }

        private static void Demo()
        {
            CustomerManager2 custumerManager = new CustomerManager2();
            custumerManager.Add(new Oracle());
        }

        private static void Interfaces()
        {
            PersonManager personManager = new PersonManager();
            Custumer custumer = new Custumer
            {
                ID = 2,
                Department = "löl"
            };
            personManager.Add(custumer);

            Students students = new Students
            {
                ID = 3,
                Address = "lölölöll"
            };
            personManager.Add(students);
        }

        interface IPerson
        {
            public int ID { get; set; }
            void get();
        }
        class Custumer : IPerson
        {
            public int ID { get; set; }
            public string Department { get; set; }
            public void get()
            {
                throw new NotImplementedException();
            }
        }

        class Students : IPerson
        {
            public int ID { get ; set; }
            public string Address { get; set; }
            public void get()
            {
                throw new NotImplementedException();
            }
        }

        class PersonManager
        {
            public void Add(IPerson person)
            {
                Console.WriteLine(person.ID);
            }
        }





    }
    
}
