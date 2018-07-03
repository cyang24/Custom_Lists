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
        public void AddtoListCustom()
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
        public void AddTwoValuesListCustom()
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
        public void AddMultipleValuesWithMathListCustom()
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
        public void AddMultipleValuesListCustom()
        {
            // Arrange
            CustomLists myList = new CustomLists();

            string value = "a";
            string expected = "a";

            // Act
            myList.Add(value);
          

            // Assert
            int actual = myList[0];
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void AddMultipleValuesListCustom()
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
            int actual = myList[1];
            Assert.AreEqual(expected, actual);
        }

      
        ///////////////////////////////// 
     

        [Test()]
        public void FindIndesOfCustom()
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
    }
}
