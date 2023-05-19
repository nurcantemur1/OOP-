using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class BasvuruManager
    {   //dependence injection
       
        public void basvuruyap(ICredi crediManager,ILoggerService loggerService) //credi artık bağımsız oldu
        {
            crediManager.Hesapla();
            loggerService.Log();
        }
        public void bilgilendirme(List<ICredi> credis,ILoggerService loggerService) 
        {
            foreach (ICredi c in credis) 
            {
                c.Hesapla();
                
            }
            loggerService.Log();
        }
        public void cokluloglama(List<ICredi> credis, List<ILoggerService> loggerServices) 
        {
            foreach (var item in credis)
            {
                foreach(var c in loggerServices) 
                {
                    item.Hesapla();
                    c.Log();
                }   
            }
        }
        public void coklulog(ICredi credis, List<ILoggerService> loggerServices)
        {       credis.Hesapla();
                foreach (var c in loggerServices)
                {
                    
                    c.Log();
                }
        }
    }
}
