using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "python";
            kurs1.Egitmen = "murat yucedag";
            kurs1.IzlenmeOrani = 80;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "c++";
            kurs2.Egitmen = "sadi evren seker";
            kurs2.IzlenmeOrani = 70;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = ".net";
            kurs3.Egitmen = "engin demırog";
            kurs3.IzlenmeOrani = 92;

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+ " "+ kurs.Egitmen + " " + kurs.IzlenmeOrani);
            }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }
}
