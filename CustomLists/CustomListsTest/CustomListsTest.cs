using NUnit.Framework;
using System;
using System.Collections.Generic;
using CustomLists;

namespace CustomListsTest
{
    [TestFixture()]
    public class CustomLists
    {
        [Test()]
        public void AddtoList()
        {
            // Arrange

            CustomLists myList = new CustomLists();

            int value = 16;
            int expected = 16;

            // Act

            myList.Add(value);

            // Assert

            int actual = myList[0];
            Assert.AreEqual(expected, actual);

        }

        [Test()]
        public void AddTwoValuesList()
        {
            // Arrange

            CustomLists myList = new CustomLists();

            int value = 16;
            int value2 = 40;
            int expected = 40;
                
            // Act

            myList.Add(value);
            myList.Add(value2);

            // Assert

            int actual = myList[1];
            Assert.AreEqual(expected, actual);

        }

        [Test()]
        public void AddMultipleValuesWithMathList()
        {
            // Arrange

            CustomLists myList = new CustomLists();

            int value = 16;
            int value2 = 40;
            int value3 = 3 + 4;
            int expected = 7;
            
            // Act

            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);

            // Assert

            int actual = myList[2];
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void AddStringList()
        {
            // Arrange

            CustomLists myList = new CustomLists();

            string value = "a";
            string expected = "a";

            // Act

            myList.Add(value);
          

            // Assert

            string actual = myList[0];
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void AddMultipleStringsList()
        {
            // Arrange

            CustomLists myList = new CustomLists();

            string value = "Hello";
            string value2 = "There";
            string value3 = "World";
            string expected = "There";

            // Act

            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);

            // Assert

            string actual = myList[1];
            Assert.AreEqual(expected, actual);
        }

      
        ///////////////////////////////// Index Of?

        [Test()]
        public void SearchIndexOfAdd()
        {
            // Arrange

            CustomLists myList = new CustomLists();
            string value = "Hello";
            string expected = 0;

            // Act

            myList.add(value);

            // Assert

            string actual = myList.IndexOf["Hello"];

            Assert.AreEqual(expected, actual);
        }


        [Test()]
        public void SearchIndexOfAfterRemoval()
        {
            // Arrange

            CustomLists myList = new CustomLists();
            string value = "Hello";
            string expected = IndexOutOfRangeException;

            // Act

            myList.Remove(value);

            // Assert

            string actual = myList.IndexOf["Hello"];

            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void FindIndexOfFalse()
        {
            // Arrange

            CustomLists myList = new CustomLists();
            bool value = true;
            bool value2 = true;
            bool value3 = true;
            bool value4 = true;
            bool value5 = false;
           

            bool expected = 4;

            // Act

            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
       


            // Assert

            string actual = myList.IndexOf[false];

            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void IndexOfStringsAdd()
        {
            // Arrange

            CustomLists myList = new CustomLists();

            string value = "a";
            string value2 = "b";
            string value3 = "c";
            string value4 = "d";
            string value5 = "e";

            string expected = "ace";

            // Act

            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);

            // Assert

            string actual = myList.IndexOf[0] + myList.IndexOf[2] + myList.IndexOf[4];
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void AddingIndexOfInt()
        {
            // Arrange

            CustomLists myList = new CustomLists();

            int value = 2;
            int value2 = 4;
            int value3 = 6;
            int value4 = 8;
            int value5 = 10;

            int expected = 6;

            // Act

            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);

            // Assert

            string actual = (myList.IndexOf[0] + myList.IndexOf[5]) - myList.IndexOf[2];
            Assert.AreEqual(expected, actual);
        }

        ///////////////////////////////// Add an object to an instance

        [Test()]
        public void IterateListAdd()
        {
            // Arrange

            CustomLists myList = new CustomLists();

            int amountToAdd = 12;
            int expected = 12;


            // Act

            for (int i = 0; i < amountToAdd; i++)
            {
                myList = new CustomLists();
                myList.Add[i];
            }
         

            // Assert

            int actual = myList.Count;

            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void IterateListRemove()
        {
            // Arrange

            CustomLists myList = new CustomLists();

            int amountToSubtract = 12;
            int expected = IndexOutOfRangeException;


            // Act

            for (int i = 0; i < amountToSubtract; i++)
            {
                myList = new CustomLists();
                myList.remove[0];
            }


            // Assert

            int actual = myList.Count;

            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void FindIndexOfCustom()
        {
            // Arrange

            CustomLists myList = new CustomLists();

            int amountToAdd = - 5;
            int expected = null;


            // Act

            for (int i = 0; i < amountToAdd; i++)
            {
                myList = new CustomLists();
                myList.Add[i];
            }


            // Assert

            int actual = myList.Count;

            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void FindIndexOfCustom()
        {
            // Arrange

            CustomLists myList = new CustomLists();

            int amountToAdd = -5;
            int expected = IndexOutOfRangeException;


            // Act

            for (int i = 0; i < amountToAdd; i++)
            {
                myList = new CustomLists();
                myList.Add[i];
            }


            // Assert

            int actual = myList.Count;

            Assert.AreEqual(expected, actual);
        }
    }
}
