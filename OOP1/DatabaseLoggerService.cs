using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //veritabanına loglama için class oluşturduk  
    class DatabaseLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
