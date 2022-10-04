using System;

namespace OOP //bu derste soyutlama işlenecek inheritance, abstract class
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri: Çiğdem Kılıç
            GercekMusteri musteri1 = new GercekMusteri();
            musteri1.Id = 1;
            musteri1.MusteriNo = "1234";
            musteri1.Adi = "Çiğdem";
            musteri1.Soyadi = "Kilic";
            musteri1.TcNo = "12345678911";

            //Musteri: Kodlama.io
            TuzelMusteri musteri2 = new TuzelMusteri();
            musteri2.Id = 2;
            musteri2.MusteriNo = "1231";
            musteri2.SirketAdi = "Kodlama.io";
            musteri2.VergiNo = "23131232";

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
           
        }
    }
}
