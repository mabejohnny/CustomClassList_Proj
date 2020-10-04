﻿using System;
using System.CodeDom;
using System.Collections;
using System.Collections.Generic;
using System.Dynamic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomClassListT;

namespace CustomListTestProject
{
    [TestClass]
    public class CustomListUnitTesting
    {

        // ADD TESTS:

        [TestMethod]
        public void Add_AddOneNumberToList_ExpectCountToIncreaseByOne()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            
            int value1 = 1;
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

            int value1 = 1;
            int value2 = 2;
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
            actual = customList.capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddFourNumbersToList_ExpectCapacityToBeDoubledFromFourToEight()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            int value1 = 1;
            int value2 = 2;
            int value3 = 3;
            int value4 = 4;
            int expected = 8;
            int actual;

            //Act
            customList.Add(value1);
            customList.Add(value2);
            customList.Add(value3);
            customList.Add(value4);
            customList.Add(value4);
            actual = customList.capacity;

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
        

        // REMOVE TESTS: 

        [TestMethod]
        public void Remove_OneNumberFromList_ExpectCountToDecreaseByOne()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
          
            int value1 = 1;
            int expected = 2;
            int actual;

            //Act
            customList.Remove(value1);
            actual = customList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_OneNumber_ZeroIndexShouldBeOne() 
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            customList.Add(2);

            int value1 = 1;
            int expected = 2;
            int actual;

            //Act
            customList.Remove(value1);
            actual = customList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Remove_TwoNumbers_ZeroIndexShouldBeThree()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
          
            int value1 = 1;
            int value2 = 2;
            int expected = 2;
            int actual;

            //Act
            customList.Remove(value1);
            customList.Remove(value2);
            actual = customList[0];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        // ToString tests:

        [TestMethod]
        public void ToString_SendInIntListOfThree_ReturnStringOfThree()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);

            string expected = "123";
            string actual;

            //Act
            actual = customList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_TakeListOfIntRemoveOne_ReturnNewStringWithOneRemoved()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);

            string expected = "12";
            string actual;

            //Act
            customList.Remove(3);
            actual = customList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        //create list
        //add values
        //for each through values
        //in each iteration, add value to string
    }
}
