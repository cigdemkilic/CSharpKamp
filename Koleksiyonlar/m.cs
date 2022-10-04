using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    public class m<TKey,TValue>
    {
        //Dictionary yapısı, [Key, Value] ikilisinden oluşan bir Collection yapısıdır.
        KeyValuePair<TKey, TValue>[] items;

        public m()
        {
            items = new KeyValuePair<TKey, TValue>[0];
        }

        public void Add(TKey key,TValue value)
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
