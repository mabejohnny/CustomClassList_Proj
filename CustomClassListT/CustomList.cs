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
            for (int i = 0; i < count; i++)
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
            if (capacity == Count)
            {
                T[] tempList = new T[capacity * 2];
          

                for (int i = 0; i < count; i++)
                {  
                    tempList[i] = customList[i];
                }
                customList = tempList; 
                
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

            for (int i = 0; i < firstList.count; i++)//iterate through first list 
            {
                tempList.Add(firstList[i]); //add each index to temp list as it loops 
            }
            for (int i = 0; i < secondList.count; i++)//iterate through second list 
            {
                tempList.Add(secondList[i]);//add each indec to temp list as it loops 
            }
            return tempList;//return temp list (firstList + secondList)
        }

        public static CustomList<T> operator -(CustomList<T> firstList, CustomList<T> secondList)
        {
            CustomList<T> tempList = new CustomList<T>(); //Temp to hold 1/2

            for (var i = 0; i < firstList.count; i++) //iterate through first list 
            {
                tempList.Add(firstList[i]);//add first list to temp list 

                for (var j = 0; j < secondList.count; j++)//iterate through secondList
                {
                    if (firstList[i].Equals(secondList[j]))//Compare each index of the firstList and secondList for equal
                    {
                        tempList.Remove(secondList[j]);//remove all that are equal 
                    }
                }
            }
            return tempList;//return tempList with firstList - secondList
        }

        public static CustomList<int> Zip(CustomList<int> one, CustomList<int> two)
        {
            CustomList<int> result = new CustomList<int>();
            int counter = one.count;
            if (counter < two.count)
            {
                counter = two.count;
            }
            

            for (int i = 0; i < counter; i++)//has to be if/ese to decide is one.count or two.count is larger 
            {
                if(one.count > i)
                {
                    result.Add(one[i]);

                }
                if(one.count < two.count)
                {
                    result.Add(two[i]);
                } 
            }
            return result;
        }

      





    }
}
