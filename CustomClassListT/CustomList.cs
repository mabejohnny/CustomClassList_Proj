﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomClassListT
{
    public class CustomList<T>
    {

        public int capacity;
        private T[] customList;
        private int count;
       

        public int Count
        {
            get
            {
                return count;
            }
        }



        public CustomList()
        {
            count = 0;
            capacity = 4;

            customList = new T[capacity];

        }

        public T this[int i]
        {
            
            get
            {
                if(i >= 0 && i <= customList.Length)
                {
                    return customList[i]; //bounds were in range, return stored value 

                }

                throw new ArgumentOutOfRangeException();


            }
            set
            {
                if (i >= 0 && i <= customList.Length)
                {
                    customList[i] = value; 
                }

                throw new ArgumentOutOfRangeException();

            }
            

        }


        public void Add(T item)
        {
            CheckCapacity();
            customList[Count] = item;
            count++;
        }

        public void Remove(T item)
        {
            for (int i = 0; i < customList.Length; i++)
            {
                if(customList[i] == )
                {

                }

            }
            customList[Count - 1] = item;
            count--;
            CheckCapacity();

        }

        private void CheckCapacity()
        {
            T[] tempList = new T[capacity];

            for (int i = 0; i < customList.Length; i++)
            {
                tempList[i] = customList[i];
            }

            if (capacity == Count)
            {
                customList = new T[capacity *= 2]; //Will double capacity based on count 
            }
            else if(capacity > 5)
            {
                customList = new T[capacity]; //will bring capacity back to 4 if items are removed and count gets less then 5
            }
        }



    }
}
