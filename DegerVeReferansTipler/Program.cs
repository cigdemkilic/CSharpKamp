using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        public static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1=? 30dur

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1=? 999dur

            //out için deneme           
            int x, y;
            Islem( out x,out y);
            Console.WriteLine("x value: {0}" + " y value: {1}", x, y);
        }
         public static void Islem(out int a,out  int b)
        {
            a = 10;
            b = 5;
            a *= a;
            b *= b;
     
        }
    } 
}
