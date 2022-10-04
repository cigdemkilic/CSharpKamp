using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    //tuzel musterı ing. coorporate
    class TuzelMusteri:Musteri // tuzel musterinin musteriden miras alma olayı-Inheritance
    {
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
