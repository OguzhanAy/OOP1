using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] tempArray = items;
            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                //Items burada eski değerlerine kavuştu.
                items[i] = tempArray[i];
            }
            //Dizinin son elemanına yeni değer atanmış olur
            items[items.Length - 1] = item;

        }
    }
}
