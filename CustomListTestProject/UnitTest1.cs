using System;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTestProject
{
    [TestClass]
    public class UnitTest1
    {

        //adding to make sure capacity doubles
        //if i add something at the 0 spot did it end up at the zero spot
        //if i called .add did the value go into the next indexer
        //if you set capacity to 4, will it add 
        //make sure my array goes into the safeArray prior to destroying
        //T[] SafeArray = new T[Capacity]




        [TestMethod]
        public void Add_AddOneNumberToList_ExpectCountToIncreaseByOne()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int newInt = 20;

            int expected = 1;
            int actual;


            //Act
            customList.Add(newInt);
            actual = customList.Count;


            //Assert
            Assert.AreEqual(expected, actual);

         

        }
        public void Add_AddTwoNumbersToList_ExpectCountToIncreaseByTwo()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int newInt = 20;
            int newInt2 = 10;

            int expected = 2;
            int actual;


            //Act
            customList.Add(newInt, newInt2);
            actual = customList.Count;


            //Assert
            Assert.AreEqual(expected, actual);



        }

        public void Add_AddOneNumberToList_ExpectCapacityToBeFour()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            int newInt = 1;

            int expected = 4;
            int actual;


            //Act
            customList.Add(newInt);
            actual = customList.Capacity;


            //Assert
            Assert.AreEqual(expected, actual);

        }

        public void Add_AddTwoNumbersToList_ExpectCapacityToBeEight()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            int newInt = 1;
            int newIntTwo = 2;

            int expected = 8;
            int actual;


            //Act
            customList.Add(newInt, newIntTwo);
            actual = customList.Capacity;


            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
