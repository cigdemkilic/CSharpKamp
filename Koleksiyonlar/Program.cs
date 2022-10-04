using System;
using GenericsIntro;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //list yapısı denendi
            //List<int> sayilar = new List<int>();
            //Console.WriteLine("List ile olusturdugumuz bos liste eleman sayisi: "+sayilar.Count);
            //list yapısı arkada bir dizi yönetir
            //boş bir liste, eleman sayısı yok bile ama arka planda yönettiğinden liste sayısını sıfır olarak verir
            // bu yüzden kendi olusturdugumuz su anki listede MyList içersinde önce dizi tanımı yapmak gerekir.

            //kendi olusturduğumuz list yapısı denendi
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Çiğdem");
            isimler.Add("Ali");

            Console.WriteLine("----------------------MyList-------------------------------");
            foreach (var s in isimler.Items)
            {
                Console.WriteLine(s);
            }

            //MyListten oluşturduğumuz bir nesneden MyList claassında oluşturduğumuz Lenght propertiesine ulaştık.
            Console.WriteLine(isimler.Lenght);
      
        }

    }
}
