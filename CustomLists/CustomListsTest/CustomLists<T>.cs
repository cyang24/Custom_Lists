using NUnit.Framework;
using System;
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

            int value = 16;


            // Act
            myList.Add(value);

            // Assert
            Assert.AreEqual(value, myList[0]);

        }
    }
}
