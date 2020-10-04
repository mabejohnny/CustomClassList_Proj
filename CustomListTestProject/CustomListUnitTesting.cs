using System;
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
           
            int value1 = 1;
            int expected = 2;
            int actual;

            //Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
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

            int value1 = 1;
            int expected = 2;
            int actual;

            //Act
            customList.Add(1);
            customList.Add(2);

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
         
            int value1 = 1;
            int value2 = 2;

            int expected = 2;
            int actual;

            //Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
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
         
            string expected = "123";
            string actual;

            //Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);

            actual = customList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_TakeListOfIntRemoveOne_ReturnNewStringWithOneRemoved()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();
      
            string expected = "12";
            string actual;

            //Act
            customList.Add(1);
            customList.Add(2);
            customList.Add(3);
            customList.Remove(3);

            actual = customList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }
        
        // Overload - Tests:

        [TestMethod]
        public void OverLoadAdd_TakeInTwoLists_ReturnFirstListAndSecondList()
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();
            CustomList<int> temp = new CustomList<int>();

            int valueOne = 1;
            int valueTwo = 3;
            int valueThree = 5;
            int value1 = 2;
            int value2 = 4;
            int value3 = 6;
          
            string expected = "135246";
            string actual;

            //Act
            firstList.Add(valueOne);
            firstList.Add(valueTwo);
            firstList.Add(valueThree);
            secondList.Add(value1);
            secondList.Add(value2);
            secondList.Add(value3);

            temp = firstList + secondList;
            actual = temp.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void OverLoadRemove_TakeInTwoLists_ReturnFirstListAndSecondList()
        {
            //Arrange
            CustomList<int> firstList = new CustomList<int>();
            CustomList<int> secondList = new CustomList<int>();
            CustomList<int> temp = new CustomList<int>();

            int valueOne = 1;
            int valueTwo = 3;
            int valueThree = 5;
            int value1 = 2;
            int value2 = 1;
            int value3 = 6;

            string expected = "35";
            string actual;

            //Act
            firstList.Add(valueOne);
            firstList.Add(valueTwo);
            firstList.Add(valueThree);
            secondList.Add(value1);
            secondList.Add(value2);
            secondList.Add(value3);

            temp = firstList - secondList;
            actual = temp.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        // CheckCapacity Tests:

        [TestMethod]
        public void CheckCapacity_TakeInListOfThree_CapacityShouldBeFour() 
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            int valueOne = 5;
            int valueTwo = 10;
            int valueThree = 15;

            int expected = 4;
            int actual;
           
            //Act
            customList.Add(valueOne);
            customList.Add(valueTwo);
            customList.Add(valueThree);

            actual = customList.capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckCapacity_TakeInListOfFour_CapacityShouldBeFour()
        {
            //Arrange
            CustomList<int> customList = new CustomList<int>();

            int valueOne = 20;
            int valueTwo = 30;
            int valueThree = 40;
            int valueFour = 50;

            int expected = 4;
            int actual;

            //Act
            customList.Add(valueOne);
            customList.Add(valueTwo);
            customList.Add(valueThree);
            customList.Add(valueFour);

            actual = customList.capacity;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void CheckZip_TakeInTwoLists_ListsShouldBeCombined()
        {
            //Arrange
            CustomList<int> customListOne = new CustomList<int>();
            CustomList<int> customListTwo = new CustomList<int>();
            CustomList<int> final = new CustomList<int>();

            int valueOne = 1;
            int valueTwo = 3;
            int valueThree = 5;
            int valueOne1 = 2;
            int valueTwo2 = 4;
            int valueThree3 = 6;

            int expected = 4;
            int actual;

            //Act
            customListOne.Add(valueOne);
            customListOne.Add(valueTwo);
            customListOne.Add(valueThree);

            customListTwo.Add(valueOne1);
            customListTwo.Add(valueTwo2);
            customListTwo.Add(valueThree3);

            actual = final.Zip(customListOne, customListTwo);

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
