using System;
using System.Collections.Generic;

namespace MyList
{
    class Program
    {
        static void Main(string[] args)
        {
            //list yapısı denendi
            List<int> sayilar = new List<int>();
            Console.WriteLine("List ile olusturdugumuz bos liste eleman sayisi: "+sayilar.Count);
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

        public class MyList<T>
        {
            T[] items;
            public MyList() // constructor, classı bir yerde otomatik newlersen otomatik çalışır
            {
                items = new T[0];
            }

            public void Add(T item)
            {
                T[] tempArray = items;
                //önceki veriler kaybolmasın diye geçici diziye aktarıyoruz
                //asagıdakı gibi newlediğimizde yeni alan oluşur ve artık oradasındır
                items = new T[items.Length + 1];
                for (int i = 0; i < tempArray.Length; i++)
                {
                    items[i] = tempArray[i];
                    //geçici diziye aktardığımız elemanları tek tek alıyoruz
                }

                items[items.Length - 1] = item;
            }
            public int Lenght
            {
                get { return items.Length; }
            }

            public T[] Items
            {
                get { return items; }
            }
        }
    }
}
