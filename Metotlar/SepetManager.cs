using System;
using System.Collections.Generic;
using System.Text;

namespace metotlar
{
    public class SepetManager
    {
        public  void Ekle(Urun urun)
        {
            Console.WriteLine("sepete eklendi: "+urun.Adi);
        }
    }
}
