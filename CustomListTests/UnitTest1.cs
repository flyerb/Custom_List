using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Sandbox;

namespace CustomListTests
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_AddedValueGoesToIndexZero()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 10;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList[0];

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Add_AddingOneValueToEmptyCustomList_CountOfCustomListIncrements()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 1;
            int actual;

            // act
            testList.Add(itemToAdd);
            actual = testList.Count;

            // assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]

        // what happens if you add multiple things (or add to a CustomList that already has some values)?
        public void Add_AddingOneValueToFullCustomList_CountOfCustomListIncrements()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int testNum1 = 20;
            int testNum2 = 30;
            int testNum3 = 4;
            int testNum4 = 5;
            int testNum5 = 12;
            int expected = 5;
            int actual;

            //act

            testList.Add(testNum1);
            testList.Add(testNum2);
            testList.Add(testNum3);
            testList.Add(testNum4);
            testList.Add(testNum5);
            actual = testList[3];
            //assert

            Assert.AreEqual(expected, actual);
        }

        // what happens to the last-added item?

        [TestMethod]
        public void Add_LastAddedItem_AddedToLastIndex()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 4;
            int actual;

            //act
            testList.Add(itemToAdd);
            actual = testList.Capacity;
            //assert

            Assert.AreEqual(expected, actual);

        }

        // what happens to the Count?
        [TestMethod]
        public void Add_ItemsAdded_AddedToTheCount()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int itemToAdd = 10;
            int expected = 1;
            int actual;

            //act
            testList.Add(itemToAdd);
            actual = testList.Count;
            //assert

            Assert.AreEqual(expected, actual);


            //Write a test that checks an increased Capacity. What if we add 5 or more things to our list. What do we expect the Capacity to be then?
        }
        public void Add_ItemsAdded_ChecksIncreasedCapacity()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int testNum1 = 20;
            int testNum2 = 30;
            int testNum3 = 4;
            int testNum4 = 5;
            int testNum5 = 12;
            int expected = 8;
            int actual;

            //act
            testList.Add(testNum1);
            testList.Add(testNum2);
            testList.Add(testNum3);
            testList.Add(testNum4);
            testList.Add(testNum5);
            actual = testList.Capacity;
            //assert

            Assert.AreEqual(expected, actual);

            //Write a test that adds 5 or more things to your list then check an index at 4 or above for the correct value based on things that you added.
        }
        public void Add_ItemsAdded_ChecksValue()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int testNum1 = 20;
            int testNum2 = 30;
            int testNum3 = 4;
            int testNum4 = 5;
            int testNum5 = 12;
            int testNum6 = 3;
            int expected = 3;
            int actual;

            //act
            testList.Add(testNum1);
            testList.Add(testNum2);
            testList.Add(testNum3);
            testList.Add(testNum4);
            testList.Add(testNum5);
            testList.Add(testNum6);
            actual = testList[5];
            //assert

            Assert.AreEqual(expected, actual);

            //Write a test that adds 5 or more things and check the count to make sure the count is working correctly.
        }

        public void Add_ItemsAdded_ChecksCount()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 6;
            int actual;

            //act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            actual = testList.Count;
            //assert

            Assert.AreEqual(expected, actual);
        }



        //      THE SUBTRACT TEST METHOD
        [TestMethod]
        public void Subtract_OneItemFromList_ChecksCount()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int testNum1 = 20;
            int testNum2 = 30;
            int testNum3 = 4;
            int testNum4 = 5;
            int testNum5 = 12;
            int testNum6 = 3;
            int expected = 5;
            int actual;

            //act
            testList.Add(testNum1);
            testList.Add(testNum2);
            testList.Add(testNum3);
            testList.Add(testNum4);
            testList.Add(testNum5);
            testList.Add(testNum6);
            testList.Remove(testNum6);
            actual = testList.Count;
            //assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Subtract_OneItemFromList_ChecksIndexOfOldValue()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int testNum1 = 20;
            int testNum2 = 30;
            int testNum3 = 4;
            int testNum4 = 5;
            int testNum5 = 12;
            int testNum6 = 3;
            int expected = 5;
            int actual;

            //act
            testList.Add(testNum1);
            testList.Add(testNum2);
            testList.Add(testNum3);
            testList.Add(testNum4);
            testList.Add(testNum5);
            testList.Add(testNum6);
            testList.Remove(testNum3);
            actual = testList[2];
            //assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Subtract_OneItemFromList_ChecksCount_AfterRemovingMiddleValue()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int testNum1 = 20;
            int testNum2 = 30;
            int testNum3 = 4;
            int testNum4 = 5;
            int testNum5 = 12;
            int testNum6 = 3;
            int expected = 5;
            int actual;

            //act
            testList.Add(testNum1);
            testList.Add(testNum2);
            testList.Add(testNum3);
            testList.Add(testNum4);
            testList.Add(testNum5);
            testList.Add(testNum6);
            testList.Remove(testNum3);
            actual = testList.Count;
            //assert

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Subtract_OneItemFromList_CheckIndex0()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int testNum1 = 20;
            int testNum2 = 30;
            int testNum3 = 4;
            int testNum4 = 5;
            int testNum5 = 12;
            int testNum6 = 3;
            int expected = 20;
            int actual;

            //act
            testList.Add(testNum1);
            testList.Add(testNum2);
            testList.Add(testNum3);
            testList.Add(testNum4);
            testList.Add(testNum5);
            testList.Add(testNum6);
            testList.Remove(testNum3);
            actual = testList[0];
            //assert

            Assert.AreEqual(expected, actual);
        }
        //[TestMethod]
        //public void Subtract_FirstItemFromList_ChecksFirstIndex()
        //{
        //    // arrange
        //    CustomList<int> testList = new CustomList<int>();
        //    int testNum1 = 20;
        //    int testNum2 = 30;
        //    int testNum3 = 4;
        //    int testNum4 = 5;
        //    int testNum5 = 12;
        //    int testNum6 = 3;
        //    int expected = 30;
        //    int actual;

        //    //act 
        //    testList.Add(testNum1);
        //    testList.Add(testNum2);
        //    testList.Add(testNum3);
        //    testList.Add(testNum4);
        //    testList.Add(testNum5);
        //    testList.Add(testNum6);
        //    testList.Remove(testNum1);
        //    actual = testList[0];
        //    //assert

        //    Assert.AreEqual(expected, actual);
        //}

        [TestMethod]
        public void Subtract_LastItemFromList_ChecksLastIndexValue()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int testNum1 = 20;
            int testNum2 = 30;
            int testNum3 = 4;
            int testNum4 = 5;
            int testNum5 = 12;
            int testNum6 = 3;
            int expected = 12;
            int actual;

            //act 
            testList.Add(testNum1);
            testList.Add(testNum2);
            testList.Add(testNum3);
            testList.Add(testNum4);
            testList.Add(testNum5);
            testList.Add(testNum6);
            testList.Remove(testNum6);
            actual = testList[4];
            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Subtract_LastItemFromList_ChecksCapacity()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int testNum1 = 20;
            int testNum2 = 30;
            int testNum3 = 4;
            int testNum4 = 5;
            int testNum5 = 12;
            int testNum6 = 3;
            int expected = 8;
            int actual;

            //act 
            testList.Add(testNum1);
            testList.Add(testNum2);
            testList.Add(testNum3);
            testList.Add(testNum4);
            testList.Add(testNum5);
            testList.Add(testNum6);
            testList.Remove(testNum6);
            actual = testList.Capacity;
            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Subtract_DuplicateItemFromList_ChecksThatFirstItemWasRemoved()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int testNum1 = 20;
            int testNum2 = 30;
            int testNum3 = 20;
            int testNum4 = 5;
            int testNum5 = 12;
            int testNum6 = 3;
            int expected = 20;
            int actual;

            //act 
            testList.Add(testNum1);
            testList.Add(testNum2);
            testList.Add(testNum3);
            testList.Add(testNum4);
            testList.Add(testNum5);
            testList.Add(testNum6);
            testList.Remove(20);
            actual = testList[1];
            //assert

            Assert.AreEqual(expected, actual);
        }

        //Unit Tests for ToString

        [TestMethod]
        public void ToString_TakesIntsReturnsString_ChecksForString()
        {
            //arrange
            CustomList<int> testList = new CustomList<int>();
            int testNum1 = 1;
            int testNum2 = 2;
            int testNum3 = 3;
            string expected = "123";
            string actual;

            //act
            testList.Add(testNum1);
            testList.Add(testNum2);
            testList.Add(testNum3);
            actual = testList.ToString();
            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_TakesInCharsReturnsString_ChecksForString()
        {
            //arrange
            CustomList<char> testList = new CustomList<char>();
            char testNum1 = 'a';
            char testNum2 = 'b';
            char testNum3 = 'c';
            string expected = "abc";
            string actual;

            //act
            testList.Add(testNum1);
            testList.Add(testNum2);
            testList.Add(testNum3);
            actual = testList.ToString();
            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void ToString_TakesInDoubleReturnsString_ChecksForString()
        {
            //arrange
            CustomList<double> testList = new CustomList<double>();
            double testNum1 = 1.5;
            double testNum2 = 2.5;
            double testNum3 = 3.5;
            string expected = "1.52.53.5";
            string actual;

            //act
            testList.Add(testNum1);
            testList.Add(testNum2);
            testList.Add(testNum3);
            actual = testList.ToString();
            //assert

            Assert.AreEqual(expected, actual);
        }


        //Unit Tests for Combine Lists

        [TestMethod]
        public void CombineList_TakesSeperateIntLists_ReturnsString()
        {
            //arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            int testNum1 = 1;
            int testNum2 = 2;
            int testNum3 = 3;
            int testNum4 = 4;
            string expected = "1234";
            CustomList<int> actual;


            //act

            testList1.Add(testNum1);
            testList1.Add(testNum2);
            testList2.Add(testNum3);
            testList2.Add(testNum4);
            actual = testList1 + testList2;

            //assert
            Assert.AreEqual(expected, actual.ToString());

        }

        //Overload + tests
        [TestMethod]
        public void ToString_ReturnsString()
        {
            //arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<char> testList2 = new CustomList<char>();
            int testNum1 = 1;
            int testNum2 = 2;
            char testNum3 = 'a';
            char testNum4 = 'b';
            string expected = "12ab";
            string actual;


            //act

            testList1.Add(testNum1);
            testList1.Add(testNum2);
            testList2.Add(testNum3);
            testList2.Add(testNum4);
            actual = testList1.ToString() + testList2.ToString();

            //assert
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void CombineList_TakesIntAndCharLists_ReturnsString()
        {
            //arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> expected = new CustomList<int>() { 1, 2, 3, 4 };
            CustomList<int> actual;

            //act
            testList1.Add(1);
            testList1.Add(2);
            testList2.Add(3);
            testList2.Add(4);
            actual = testList1 + testList2;

            //assert
            Assert.AreEqual(expected.ToString(), actual.ToString());

        }

        // Overload - Tests

        [TestMethod]
        public void OverloadMinus_TakesTwoLists_ReturnsOneListWithoutIndex0()
        {
            //arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> expected = new CustomList<int>() {2, 4};
            CustomList<int> actual;

            //act
            testList1.Add(1);
            testList1.Add(2);
            testList2.Add(3);
            testList2.Add(4);
            actual = testList1 - testList2;

            //assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod]
        public void OverloadMinus_TakesOneList_ReturnsOneListWithoutIndex0()
        {
            //arrange
            CustomList<int> testList1 = new CustomList<int>();
            CustomList<int> testList2 = new CustomList<int>();
            CustomList<int> expected = new CustomList<int>() {234};
            CustomList<int> actual;

            //act
            testList1.Add(1);
            testList1.Add(2);
            testList1.Add(3);
            testList1.Add(4);
            actual = testList1 - testList2;

            //assert
            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}



 
