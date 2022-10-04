using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //bir krediye basvuru alıcaz
    class BasvuruManager
    {
        public void BasvuruYap(IKrediManager krediManager, ILoggerService loggerServices)
        {
            krediManager.Hesapla();
            loggerServices.Log();
        }
        // tek bir kredi türü hesaplaması

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach (var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
        //birden fazla kredi türü hesaplaması


        public void BasvuruYap1(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            krediManager.Hesapla();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
                //birden fazla loglama yapabilmek için list kullandık
            }
        }
    }
}
