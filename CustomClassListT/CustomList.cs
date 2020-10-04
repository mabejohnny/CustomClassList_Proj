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

            for (int i = 0; i < count; i++)
            {
                stringToDisplay += customList[i]; 
                
            }
            return stringToDisplay;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < count; i++)
            {
                yield return customList[i];
            }
        }

        public static CustomList<T> operator +(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> tempList = new CustomList<T>(); //Temp to hold 1/2

            for (int i = 0; i < firstList.count; i++)
            {
                tempList.Add(firstList[i]);
            }
            for (int i = 0; i < secondList.count; i++)
            {
                tempList.Add(secondList[i]);
            }
            return tempList;
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> tempList = new CustomList<T>(); //Temp to hold 1/2

            for (var i = 0; i < firstList.count; i++)
            {
                tempList.Add(firstList[i]);

                for (var j = 0; j < secondList.count; j++)
                {
                    if (firstList[i].Equals(secondList[j]))
                    {
                        tempList.Remove(secondList[j]);
                    }
                }
            }
            return tempList;
        }







        public static CustomList<int> Zip(CustomList<int> one, CustomList<int> two)
        {
            CustomList<int> result = new CustomList<int>();

            for (int i = 0; i < one.Count; i++)
            {
                result.Add(one[i]);
                result.Add(two[i]);

            }


            //to test
            CustomList<int> charlesIsTHEBest = new CustomList<int>();//give values to this list
            CustomList<int> charlesIsTHEBestAswell = new CustomList<int>();//give values to this list
            CustomList<int> finalList = new CustomList<int>();//left blank
            finalList = finalList.Zip(charlesIsTHEBest, charlesIsTHEBestAswell);

        } 
    }
}
