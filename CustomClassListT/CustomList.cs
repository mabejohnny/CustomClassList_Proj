using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClassListT
{
    public class CustomList<T>
    {
        public int count;
        public int capacity;

        private T[] customList;



        public CustomList()
        {
            count = 0;
            capacity = 4;

            customList = new T[capacity];

        }


        public void Add(T item)
        {
            CheckCapacity();
            customList[count] = item;
            count++;
        }

        public void Remove(T item)
        {


        }

        private void CheckCapacity()
        {
            T[] tempList = new T[capacity];

            for (int i = 0; i < customList.Length; i++)
            {
                tempList[i] = customList[i];
            }

            if (capacity == count)
            {
                customList = new T[capacity *= 2];
            }
        }



    }
}
