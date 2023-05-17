using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsInPro
{
    class MyList<T>
    {
        T[] items;
        public MyList() //constructor
        {
            items = new T[0];
        }
        public void Add(T item) 
        {
            T[] tempArray = items;
            items = new T[items.Length+1]; //yeni yer açma eklemek için
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }
            items[items.Length-1] = item; //son eleman index olarak -1 de yer alır
        }
    }
}
