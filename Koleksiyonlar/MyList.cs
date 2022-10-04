using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
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
