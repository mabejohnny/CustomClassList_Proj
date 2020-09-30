using System;
using System.Collections.Generic;
using System.Text;

namespace CustomClassList
{
    public class CustomList<T>
    {
        public int count;
        public int capacity;

        private T[] _items;


        public CustomList()
        {
            count = 0;
            capacity = 4;

            _items = new T[capacity];

        }
     

        public void Add(T item)
        {
            _items[count] = item;
            count++;
            //_items = new T[capacity *= 2];
        }



    }
}
