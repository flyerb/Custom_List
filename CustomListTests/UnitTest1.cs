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
            int expected = 5;
            int actual;

            //act

            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            actual = testList[4];
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
            actual = testList.capacity;
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
            actual = testList.count;
            //assert

            Assert.AreEqual(expected, actual);


            //Write a test that checks an increased Capacity. What if we add 5 or more things to our list. What do we expect the Capacity to be then?
        }
        public void Add_ItemsAdded_ChecksIncreasedCapacity()
        {
            // arrange
            CustomList<int> testList = new CustomList<int>();
            int expected = 8;
            int actual;

            //act
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            actual = testList.capacity;
            //assert

            Assert.AreEqual(expected, actual);

            //Write a test that adds 5 or more things to your list then check an index at 4 or above for the correct value based on things that you added.
        }
        public void Add_ItemsAdded_ChecksValue()
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
                actual = testList.count;
                //assert

                Assert.AreEqual(expected, actual);
            }





            //      THE SUBTRACT TEST METHOD


        }
    }
}
