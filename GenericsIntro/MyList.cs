using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro
{
    public class MyList<T>
    {
        T[] items;
        public MyList()
        {
            items = new T[0];
        }
        public void Add(T item)
        {
            T[] temppArray = items;
            items=new T[items.Length+1];
            for (int i = 0; i < temppArray.Length; i++)
            {
                items[i] = temppArray[i];
            }
            items[items.Length-1] = item;
        }
      
    }
}
