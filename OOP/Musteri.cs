using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{ 
    class Musteri
    {
        public int Id { get; set; }
        public string MusteriNo { get; set; }
        //Id ve MusteriNo her iki musteri türü classında ortak olduğubdan
        //bu iki özelliği musteri classlarının(gercek,tüzel) miras aldığı Musteri classına ekledim
        //miras aldıklarından dolayı bu iki özelliğe erişebileceklerdir.


    }
}
