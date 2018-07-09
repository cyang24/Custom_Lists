using NUnit.Framework;
using System;
using System.Collections.Generic;
using CustomLists;

namespace CustomListsTest
{
    [TestFixture()]
    public class CustomLists
    {
        /////////////////////////////////// Add to list


        //[Test()]
        //public void AddtoList()
        //{
        //     //Arrange

        //    CustomLists<int> myList = new CustomLists<int>();

        //    int value = 16;
        //    int expected = 16;

        //    // Act

        //    myList.Add(value);

        //    // Assert

        //    int actual = myList[0];
        //    Assert.AreEqual(expected, actual);

        //}

        //[Test()]
        //public void AddTwoValuesList()
        //{
        //    // Arrange

        //    CustomLists<int> myList = new CustomLists<int>();

        //    int value = 16;
        //    int value2 = 40;
        //    int expected = 40;
                
        //    // Act

        //    myList.Add(value);
        //    myList.Add(value2);

        //    // Assert

        //    int actual = myList[1];
        //    Assert.AreEqual(expected, actual);

        //}

        //[Test()]
        //public void AddMultipleValuesWithMathList()
        //{
        //    // Arrange

        //    CustomLists<int> myList = new CustomLists<int>();

        //    int value = 16;
        //    int value2 = 40;
        //    int value3 = 3 + 4;
        //    int value4 = 40;
        //    int value5 = 11;
        //    int value6 = 9;
        //    int value7 = 35;
        //    int value8 = 90;
        //    int value9 = 1;
        //    int value10 = 21;

          

        //    int expected = 90;
            
        //    // Act

        //    myList.Add(value);
        //    myList.Add(value2);
        //    myList.Add(value3);
        //    myList.Add(value4);
        //    myList.Add(value5);
        //    myList.Add(value6);
        //    myList.Add(value7);
        //    myList.Add(value8);
        //    myList.Add(value9);
        //    myList.Add(value10);
           

        //    // Assert

        //    int actual = myList[7];

        //    Assert.AreEqual(expected, actual);
        //}

        //[Test()]
        //public void AddStringList()
        //{
        //    // Arrange

        //    CustomLists<string> myList = new CustomLists<string>();

        //    string value = "a";
        //    string expected = "a";

        //    // Act

        //    myList.Add(value);
          

        //    // Assert

        //    string actual = myList[0];
        //    Assert.AreEqual(expected, actual);
        //}

        ////public void AddObjectsFromList()
        ////{
        //    ////Arrange
        //    //CustomLists<string> myList = new CustomLists<string>();

        //    //CustomLists<TesterObjects> colors = new CustomLists<TesterObjects>();
           
        //    //int expected = 6;
           
        //    ////Act
           

        //    ////Assert
        //    //int actual = myList.;

        //    //Assert.AreEqual(expected, actual);

        ////}

        ///////////////////////////////// Remove from lists

        //[Test()]
        //public void RemoveIntFromList()
        //{
        //    //Arrange
        //    CustomLists<int> myList = new CustomLists<int>();
        //    int value = 5;
        //    int value2 = 10;
        //    int value3 = 20;
        //    int expected = 20;

        //    //Act
        //    myList.Add(value);
        //    myList.Add(value2);
        //    myList.Add(value3);

        //    myList.Remove(value2);

        //    int actual = myList[1];

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}

        //[Test()]
        //public void RemoveStringFromList()
        //{
        //    //Arrange
        //    CustomLists<string> myList = new CustomLists<string>();
        //    myList.Add("What");
        //    myList.Add("color");
        //    myList.Add("are");
        //    myList.Add("your");
        //    myList.Add("shoes?");
        //    myList.Add(".");

        //    string expected = "are";
        //    myList.Remove("your");
        //    //Act

        //    string actual = myList[2];
                                               
        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}

        //[Test()]
        //public void RemoveObjectsFromList()
        //{
        //    //Arrange
        //    CustomLists myList = new CustomLists();

        //    CustomLists colors = new CustomLists();
        //    colors.Add("red");
        //    colors.Add("orange");
        //    colors.Add("yellow");

        //    CustomLists colors2 = new CustomLists();
        //    colors2 = new CustomLists();
        //    colors2.Add("green");
        //    colors2.Add("blue");
        //    colors2.Add("indigo");

        //    CustomLists expected = colors;

        //    //Act
        //    myList = myList.Add(colors) + myList.Add(colors2);
        //    myList = myList - myList.Remove(colors2);

        //    //Assert
        //    CustomLists actual = myList;

        //    Assert.AreEqual(expected, actual);

        //}

      
        ///////////////////////////////// Count Property

        //[Test()]
        //public void CountStringsInList()
        //{
        //    //Arrange
        //    CustomLists myList = new CustomLists(); 
        //    myList.Add("red");
        //    myList.Add("orange");
        //    myList.Add("yellow");

        //    int expected = 3;

        //    //Act
        //    int actual = myList.Count;

        //    //Assert

        //    Assert.AreEqual(expected, actual);
        //}

        //[Test()]
        //public void CountObjectsList()
        //{
        //    //Arrange
         
        //    CustomLists colors = new CustomLists();
        //    colors.Add("red");
        //    colors.Add("orange");
        //    colors.Add("yellow");

        //    CustomLists colors2 = new CustomLists();
        //    colors2 = new CustomLists();
        //    colors2.Add("green");
        //    colors2.Add("blue");
        //    colors2.Add("indigo");

        //    CustomLists myList = new CustomLists();
        //    myList.Add(colors);
        //    myList.Add(colors2);

        //    int expected = 6;

        //    //Act
        //    int actual = myList.Count;

        //    //Assert
        //    Assert.AreEqual(expected, actual);
        //}

        /////////////////////////////////// Add an object to an instance

        //[Test()]
        //public void IterateListAddObject()
        //{
        //    // Arrange

        //    CustomLists myList = new CustomLists();

        //    int amountToAdd = 12;
        //    int expected = 12;


        //    // Act
        //    foreach(int x in myList)
        //    {
                
        //    }

        //    //for (int i = 0; i < amountToAdd; i++)
        //    //{
        //    //    myList = new CustomLists();
        //    //    myList.Add(myList);
        //    //}
         

        //    // Assert

        //    int actual = myList.Count;

        //    Assert.AreEqual(expected, actual);
        //}

        //[Test()]
        //public void IterateListObject2()
        //{
        //    // Arrange

        //    CustomLists myList = new CustomLists();

        //    int amountToAdd = 12;
        //    int expected = 24;


        //    // Act

        //    for (int i = 0; i < amountToAdd; i++)
        //    {
        //        myList = new CustomLists();
        //        myList.Add(i) += myList.Add(i);
        //    }


        //    // Assert

        //    int actual = myList.Count;

        //    Assert.AreEqual(expected, actual);
        //}

        //[Test()]
        //public void IterateListAddIfMath()
        //{
        //    // Arrange

        //    CustomLists myList = new CustomLists();

        //    int amountToAdd = 6 + 7;
        //    int expected = 13;


        //    // Act

        //    for (int i = 0; i < amountToAdd; i++)
        //    {
        //        myList = new CustomLists();
        //        myList.Add(i);
        //    }


        //    // Assert

        //    int actual = myList.Count;

        //    Assert.AreEqual(expected, actual);
        //}

        //[Test()]
        //public void IterateListAddNegativeInt()
        //{
        //    // Arrange

        //    CustomLists myList = new CustomLists();

        //    int amountToAdd = -5;
        //    int expected = IndexOutOfRangeException;


        //    // Act

        //    for (int i = 0; i < amountToAdd; i++)
        //    {
        //        myList = new CustomLists();
        //        myList.Add(i);
        //    }


        //    // Assert

        //    int actual = myList.Count;

        //    Assert.AreEqual(expected, actual);
        //}

        /////////////////////////////////// Remove an object to an instance

        //[Test()]
        //public void IterateListRemove()
        //{
        //    // Arrange

        //    CustomLists myList = new CustomLists();

        //    int amountToSubtract = 12;
        //    int expected = IndexOutOfRangeException;


        //    // Act

        //    for (int i = 0; i < amountToSubtract; i++)
        //    {
        //        myList = new CustomLists();
        //        myList.Remove[0];
        //    }


        //    // Assert

        //    int actual = myList.Count;

        //    Assert.AreEqual(expected, actual);
        //}

        //[Test()]
        //public void IterateListRemoveNegativeInt()
        //{
        //    // Arrange

        //    CustomLists myList = new CustomLists();

        //    int amountToSubtract = -2;
        //    int expected = null;


        //    // Act

        //    for (int i = 0; i < amountToSubtract; i++)
        //    {
        //        myList = new CustomLists();
        //        myList.remove(0);
        //    }


        //    // Assert

        //    int actual = myList.Count;

        //    Assert.AreEqual(expected, actual);
        //}

   

        /////////////////////////////////// Override String Method

        [Test()]
        public void IntInListToString()
        {
            //Arrange
            CustomLists<int> myList = new CustomLists<int>();
            myList.Add(1);
            myList.Add(7);
            myList.Add(18);
            myList.Add(24);
            myList.Add(58);

            string expected = "17182458";

            //Act
            string actual = myList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void StringInListToString()
        {
            //Arrange
            CustomLists<string> myList = new CustomLists<string>();
            myList.Add("This ");
            myList.Add("is ");
            myList.Add("a ");
            myList.Add("string ");
            myList.Add("test!");

            string expected = "This is a string test!";

            //Act
            string actual = myList.ToString();

            //Assert
            Assert.AreEqual(expected, actual);
        }


        /////////////////////////////////// Overload Plus Sign Operator


        //[Test()]
        //public void OverloadPlusSignOperatorAddTwoListsTogether()
        //{
        //    //Arrange
        //    CustomLists myList = new CustomLists();
        //    Add.mylist(0);
        //    Add.mylist(1);
        //    Add.mylist(2);
        //    Add.mylist(3);
        //    Add.mylist(4);

        //    CustomLists myList2 = new CustomLists();
        //    Add.mylist(4);
        //    Add.mylist(3);
        //    Add.mylist(2);
        //    Add.mylist(1);
        //    Add.mylist(0);

        //    int expected = 3;

        //    //Act
        //    CustomLists actual = myList + myList2;


        //    //Assert     
        //    Assert.AreEqual(expected, actual[6]);
        //}

        /////////////////////////////////// Overload Minus Sign Operator


        //[Test()]
        //public void OverloadMinusSignOperatorSubtractTwoListsTogether()
        //{
        //    //Arrange
        //    CustomLists myList = new CustomLists();
        //    Add.mylist(0);
        //    Add.mylist(1);
        //    Add.mylist(2);
        //    Add.mylist(3);
        //    Add.mylist(4);
        //    Add.mylist(5);

        //    CustomLists myList2 = new CustomLists();
        //    Add.mylist(4);
        //    Add.mylist(3);
        //    Add.mylist(2);
        //    Add.mylist(1);
        //    Add.mylist(0);

        //    int expected = 5;

        //    //Act
        //    CustomLists actual = myList - myList2;


        //    //Assert     
        //    Assert.AreEqual(expected, actual[0]);
        //}
    }
}
