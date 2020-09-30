using System;
using System.Collections.Generic;
using System.Text;

namespace CustomClassList
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

            //create new T to hold old T while adding items
            T[] tempList = new T[capacity];

            for (int i = 0; i < customList.Length; i++)
            {
                tempList[i] = customList[i];   
            }
            count++;
            customList = tempList;
        
        }

        //check capacity if count hits capacity, it will double capacity value
        public void CheckCapacity()
        {
            if (capacity == count)
            {
                customList = new T[capacity *= 2];

            }
            else if (count < 4)
            {
                customList = new T[capacity];
            }

        }



    }
}
