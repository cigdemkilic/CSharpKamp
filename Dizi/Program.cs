using System;
using System.Collections.Generic;

namespace deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            //koleksiyonlar system.collection.generic sınıfında yer alır 
            List<string> krediler = new List<string>(); //liste tanımlama
            krediler.Add("özel"); //tek tek deger atama
            krediler.Add("mutlu emekli");
            krediler.Add("hızlı kredi");

            for (int i=0;i< krediler.Count; i++)
            {
                string a = krediler[i];
                Console.WriteLine(a);
            }

            List<char> harf = new List<char>() { 'a', 'b', 'c' }; //tanımlama sırasında değer atama
            harf.Add('d'); //listler dinamiktir
            Console.WriteLine(harf[3]); 

            //-------------------------------------------------------

            //arrayler(dizi) genişletilemez bunun için list kullanılmalıdır
            int[] sayilar = new int[3] ; //dizi tanımlama
            sayilar[0] = 1;
            sayilar[1] = 2;
            sayilar[2] = 3;

            int[] sayi ={ 5,7,12,36};
            // tanımlama sırasında int tipi diziye değer girişi
            
            string[] isimler = { "Ahmet", "Mehmet", "Burak", "Hasan" };
            // tanımlama sırasında string tipinde diziye değer girişi
            
            char[] harfler = { 'k', 'l', 'h', 'Y' };
            // tanımlama sırasında char tipindeki diziye değer atama

            for (int i=0; i < sayi.Length; i++)
            {
                Console.WriteLine(sayi[i]);
            }
        }
    }
}
