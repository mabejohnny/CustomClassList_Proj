using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CustomListTestProject
{
    [TestClass]
    public class CustomListUnitTesting
    {

        //adding to make sure capacity doubles [X]
        //if i add something at the 0 spot did it end up at the zero spot [0]
        //if i called .add did the value go into the next indexer
        //if you set capacity to 4, will it add 
        //make sure my array goes into the safeArray prior to destroying
        //T[] SafeArray = new T[Capacity]


        // ADD:

        [TestMethod]
        public void Add_AddOneNumberToList_ExpectCountToIncreaseByOne()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 20;
            int expected = 1;
            int actual;


            //Act
            customList.Add(value1);
            actual = customList.Count;


            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_AddTwoNumbersToList_ExpectCountToIncreaseByTwo()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 20;
            int value2 = 10;

            int expected = 2;
            int actual;


            //Act
            customList.Add(value1);
            customList.Add(value2);
            actual = customList.Count;


            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_AddOneNumberToList_ExpectCapacityToBeFour()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int expected = 4;
            int actual;


            //Act
            customList.Add(value1);
            actual = customList.Capacity;


            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_AddTwoNumbersToList_ExpectCapacityToBeEight()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int expected = 8;
            int actual;


            //Act
            customList.Add(value1);
            customList.Add(value2);
            actual = customList.Capacity;


            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_OneNumber_ZeroIndexShouldBeOne()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int expected = 1;
            int actual;


            //Act
            customList.Add(value1);
            actual = customList[0];


            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_TwoNumbes_OneIndexShouldBeTwo()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int expected = 2;
            int actual;


            //Act
            customList.Add(value1);
            customList.Add(value2);
            actual = customList[1];


            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Add_OneNumberToList_ListWillBeOverCountAndThrowException()  //Ask Charles to go over testing for exceptions
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
           


            //Act
            customList.Add(value1);
            customList.Add(value2);
            actual = customList[1];


            //Assert
            Assert.AreEqual(expected, actual);

        }


        // REMOVE: 

        [TestMethod]
        public void Remove_OneNumberFromList_ExpectCountToDecreaseByOne()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int expected = 0;
            int actual;


            //Act
            customList.Remove(value1);
            actual = customList.Count;


            //Assert
            Assert.AreEqual(expected, actual);

        }

        public void Remove_OneNumberFromList_Value2ToMoveToIndex0()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int expected = 2;
            int actual;


            //Act
            customList.Remove(value1);
            actual = customList[0];


            //Assert
            Assert.AreEqual(expected, actual);


        }

        public void Remove_TwoNumbers_OneIndexShouldBeThree()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int expected = 2;
            int actual;


            //Act
            customList.Remove(value1);
            customList.Remove(value2);
            actual = customList[1];


            //Assert
            Assert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void Remove_OneNumberFromList_ListWillBeUnderCountAndThrowException()  //Ask Charles to go over testing for exceptions
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();



            //Act
           


            //Assert
            

        }


    }
}
