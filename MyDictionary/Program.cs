using System;
using System.Collections.Generic;


namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            //dictionary yapısı denendi
            Dictionary<int, string> monthsDeneme = new Dictionary<int, string>
            {
              {1,"January"},{2,"Februay"},{3,"March"},{4,"April"},{5,"May"},{6,"June"},
              {7,"July"},{8,"August"},{9,"September"},{10,"Octaber"},{11,"November"},{12,"December"}
            };

            Console.WriteLine("----------------------Dictionary---------------------------");
            foreach (var m in monthsDeneme)
            {
                Console.WriteLine(m.Key + " " + m.Value);
            }

            //Dictionary<int, int> sayi = new Dictionary<int, int> { };
            //Console.WriteLine("Dictionary ile olusturdugumuz bos liste eleman sayisi: " + sayi.Count);
            // içerisinde hiçbir değer olmamasına rağmen sıfır döndürdü bu da demek oluyo ki tıpkı List gibi arkada bir dizi yönetiyor.
            // bu yüzden kendi olusturdugumuz su anki MyDictonary içersinde önce dizi tanımı yapmak gerekir.
            //kendi oluşturduğumuz dictionary yapısı denendi

            MyDictionary<int, string> months = new MyDictionary<int, string>();
            months.Add(1, "January");
            months.Add(2, "February");
            months.Add(3, "March");
            Console.WriteLine("----------------------MyDictionary-------------------------");
            months.ShowList();
            Console.WriteLine("...");

        }

        public class MyDictionary<TKey, TValue>
        {
            //Dictionary yapısı, [Key, Value] ikilisinden oluşan bir Collection yapısıdır.
            KeyValuePair<TKey, TValue>[] items;

            public MyDictionary()
            {
                items = new KeyValuePair<TKey, TValue>[0];
            }

            public void Add(TKey key, TValue value)
            {
                KeyValuePair<TKey, TValue>[] tempArray = items;
                items = new KeyValuePair<TKey, TValue>[items.Length + 1];

                for (int i = 0; i < tempArray.Length; i++)
                {
                    items[i] = tempArray[i];

                }
                items[items.Length - 1] = new KeyValuePair<TKey, TValue>(key, value);
            }

            public void ShowList()
            {
                foreach (var item in items)
                {
                    Console.WriteLine(item.Key + " " + item.Value);
                }
            }
        }
    }
}
