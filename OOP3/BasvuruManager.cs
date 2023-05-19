using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {   //dependence injection
       
        public void basvuruyap(ICredi crediManager) //credi artık bağımsız oldu
        {
            crediManager.Hesapla();
            
        }
        public void bilgilendirme(List<ICredi> credis) 
        {
            foreach (ICredi c in credis) 
            {
                c.Hesapla();
            }
        }
    }
}
