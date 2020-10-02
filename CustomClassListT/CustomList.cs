using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace CustomClassListT
{
    public class CustomList<T> : IEnumerable 
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
                    return customList[i]; 
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
                
            }
            set
            {
                if (i >= 0 && i <= customList.Length)
                {
                    customList[i] = value; 
                }
                else
                {
                    throw new ArgumentOutOfRangeException();
                }
            }
        }

        public void Add(T item)
        {
            CheckCapacity();
            customList[count] = item;
            count++;
        }

        public void Remove(T item)
        {
            for (int i = 0; i < customList.Length; i++)
            {
                if(customList[i].Equals(item))
                {
                    customList[i] = customList[i + 1];
                    count--;
                }
            }     
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
                customList = new T[capacity *= 2]; 
            }

        }

        public override string ToString()
        {
            string stringToDisplay = "";

            for (int i = 0; i < customList.Length - 1; i++)
            {
                stringToDisplay += customList[i]; 
                
            }
            return stringToDisplay;

        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < customList.Length; i++)
            {
                yield return customList[i];
            }
        }

    }
}
