using NUnit.Framework;
using System;
using System.Collections.Generic;
using CustomLists;

namespace CustomListsTest
{
    [TestFixture()]
    public class CustomLists<T>
    {
        [Test()]
        public void AddtoListCustom()
        {   
            // Arrange
            CustomLists<T> myList = new CustomLists<T>();

            int expected = 16;


            // Act
            myList.Add(expected);

            // Assert
            int actual = myList[0];
            Assert.AreEqual(expected, actual);

        }
    }
}
