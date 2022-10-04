 using System;
using metotlar;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Adi = "ceket";
            urun1.Aciklama = " kot ceket";
            urun1.Fiyati = 150;

            Urun urun2 = new Urun();
            urun2.Adi = "etek";
            urun2.Aciklama = "çiçekli etek";
            urun2.Fiyati = 80;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi + " " + urun.Aciklama + " " + urun.Fiyati);
            }

            Console.WriteLine("-----------------metotlar-----------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun2);
        }
    }
}
