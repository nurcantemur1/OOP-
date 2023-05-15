using System;

namespace Interfaces
{
     class Oracle : ICustomerDal
     {
        public void Add()
        {
            Console.WriteLine(" Oracle'a eklendi");
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}