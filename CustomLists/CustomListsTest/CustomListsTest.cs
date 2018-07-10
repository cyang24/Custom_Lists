using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Collections;
using CustomLists;

namespace CustomListsTest
{
    [TestFixture()]
    public class CustomListsTest
    {
        /////////////////////////////////// Add to list


        [Test()]
        public void AddtoList()
        {
             //Arrange

            CustomLists<int> myList = new CustomLists<int>();

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

            CustomLists<int> myList = new CustomLists<int>();

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

            CustomLists<int> myList = new CustomLists<int>();

            int value = 16;
            int value2 = 40;
            int value3 = 3 + 4;
            int value4 = 40;
            int value5 = 11;
            int value6 = 9;
            int value7 = 35;
            int value8 = 90;
            int value9 = 1;
            int value10 = 21;



            int expected = 90;

            // Act

            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);
            myList.Add(value6);
            myList.Add(value7);
            myList.Add(value8);
            myList.Add(value9);
            myList.Add(value10);


            // Assert

            int actual = myList[7];

            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void AddStringList()
        {
            // Arrange

            CustomLists<string> myList = new CustomLists<string>();

            string value = "a";
            string expected = "a";

            // Act

            myList.Add(value);


            // Assert

            string actual = myList[0];
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void AddObjectsFromList()
        {
            
            List<TesterObjects> myList = new List<TesterObjects>();

            int expected = 4;

        //Act

            myList.Add(new TesterObjects("Todd", 12));
            myList.Add(new TesterObjects("John", 15));
            myList.Add(new TesterObjects("Bob", 17));
            myList.Add(new TesterObjects("Steve", 26));

        //Assert

            int actual = myList.Count;

            Assert.AreEqual(expected, actual);


        }

        ///////////////////////////////// Remove from lists

        [Test()]
        public void RemoveIntFromList()
        {
            //Arrange
            CustomLists<int> myList = new CustomLists<int>();
            int value = 5;
            int value2 = 10;
            int value3 = 20;
            int expected = 20;

            //Act
            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);

            myList.Remove(value2);

            int actual = myList[1];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void RemoveIntFromList_CheckLastIndex()
        {
            //Arrange
            CustomLists<int> myList = new CustomLists<int>();
            int value = 5;
            int value2 = 10;
            int value3 = 20;
            int value4 = 15;
            int value5 = 60;

            int expected = 60;

            //Act
            myList.Add(value);
            myList.Add(value2);
            myList.Add(value3);
            myList.Add(value4);
            myList.Add(value5);


            myList.Remove(value3);

            int actual = myList[4];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void RemoveStringFromList()
        {
            //Arrange
            CustomLists<string> myList = new CustomLists<string>();
            myList.Add("What");
            myList.Add("color");
            myList.Add("are");
            myList.Add("your");
            myList.Add("shoes?");
            myList.Add(".");

            string expected = "are";
            myList.Remove("your");
            //Act

            string actual = myList[2];

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void RemoveStringFromList_CheckCount()
        {
            //Arrange
            CustomLists<string> myList = new CustomLists<string>();
            myList.Add("What");
            myList.Add("color");
            myList.Add("are");
            myList.Add("your");
            myList.Add("shoes?");
            myList.Add(".");

            int expected = 5;
            myList.Remove("your");
            //Act

            int actual = myList.Count;

            //Assert
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void RemoveObjectsFromList()
        {
            //Arrange

            List<TesterObjects> myList = new List<TesterObjects>();
            myList.Add(new TesterObjects("Todd", 12));
            myList.Add(new TesterObjects("John", 15));
            myList.Add(new TesterObjects("Bob",  17));
            myList.Add(new TesterObjects("Steve", 26));

            int expected = 3;

            //Act

            myList.Remove(myList[0]);

            //Assert

            int actual = myList.Count;

            Assert.AreEqual(expected, actual);

        }


        /////////////////////////////////// Override String Method

        [Test()]
        public void IntListToString()
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
        public void StringListToString()
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


        ///////////////////////////////// Overload Plus Sign Operator


        [Test()]
        public void OverloadPlusSignOperatorAddTwoListsIntTogether()
        {
            //Arrange

            CustomLists<int> myList = new CustomLists<int>();

            CustomLists<int> listA = new CustomLists<int>();
            listA.Add(0);
            listA.Add(1);
            listA.Add(2);
            listA.Add(3);
            listA.Add(4);

            CustomLists<int> listB = new CustomLists<int>();
            listB.Add(4);
            listB.Add(3);
            listB.Add(2);
            listB.Add(1);
            listB.Add(0);

            int expected = 4;

            //Act
            myList.OverloadPlusOperator(listA, listB);

            int actual = myList[6];

            //Assert     
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void OverloadPlusSignOperatorAddTwoListsIntCount()
        {
            //Arrange

            CustomLists<int> myList = new CustomLists<int>();

            CustomLists<int> listA = new CustomLists<int>();
            listA.Add(0);
            listA.Add(1);
            listA.Add(2);
            listA.Add(3);
            listA.Add(4);

            CustomLists<int> listB = new CustomLists<int>();
            listB.Add(4);
            listB.Add(3);
            listB.Add(2);
            listB.Add(1);
            listB.Add(0);

            int expected = 9;

            //Act
            myList.OverloadPlusOperator(listA, listB);

            int actual = myList.Count;

            //Assert     
            Assert.AreEqual(expected, actual);
        }

        [Test()]
        public void OverloadPlusSignOperatorAddTwoListsStringTogether()
        {
            //Arrange

            CustomLists<string> myList = new CustomLists<string>();

            CustomLists<string> listA = new CustomLists<string>();
            listA.Add("a");
            listA.Add("b");
            listA.Add("c");
            listA.Add("d");
            listA.Add("e");

            CustomLists<string> listB = new CustomLists<string>();
            listB.Add("1");
            listB.Add("2");
            listB.Add("3");
            listB.Add("4");
            listB.Add("5");

            string expected = "3";

            //Act
            myList.OverloadPlusOperator(listA, listB);

            string actual = myList[7];

            //Assert     
            Assert.AreEqual(expected, actual);
        }

        /////////////////////////////////// Overload Minus Sign Operator


        [Test()]
        public void OverloadMinusSignOperatorSubtractTwoIntListsTogether()
        {
            //Arrange
            CustomLists<int> myLists = new CustomLists<int>();

            CustomLists<int> listA = new CustomLists<int>();
            listA.Add(0);
            listA.Add(1);
            listA.Add(2);
            listA.Add(3);
            listA.Add(4);
            listA.Add(5);

            CustomLists<int> listB = new CustomLists<int>();
            listB.Add(4);
            listB.Add(3);
            listB.Add(2);
            listB.Add(1);
            listB.Add(0);

            int expected = 5;

            //Act

            myLists.OverloadMinusOperator(listA, listB);

            {
            //Assert  
            int actual = myLists[0];
            Assert.AreEqual(expected, actual);
            }
        }

        [Test()]
        public void OverloadMinusSignOperatorSubtractTwoStringsListsTogether()
        {
            //Arrange

            CustomLists<string> myList = new CustomLists<string>();

            CustomLists<string> listA = new CustomLists<string>();
            listA.Add("a");
            listA.Add("b");
            listA.Add("c");
            listA.Add("d");
            //listA.Add("e");

            CustomLists<string> listB = new CustomLists<string>();
            listB.Add("b");
            listB.Add("d");
            listB.Add("d");
            listB.Add("a");
            listB.Add("b");

            string expected = "d";

            //Act
            myList.OverloadMinusOperator(listA, listB);

            string actual = myList[0];

            //Assert     
            Assert.AreEqual(expected, actual);
        }

        /////////////////////////////////// Zip Two Lists


        [Test()]
        public void ZipTwoListsInt()
        {
            //Arrange
            CustomLists<int> myLists = new CustomLists<int>();

            CustomLists<int> listA = new CustomLists<int>();
            listA.Add(0);
            listA.Add(1);
            listA.Add(2);
            listA.Add(3);
            listA.Add(4);
            listA.Add(5);

            CustomLists<int> listB = new CustomLists<int>();
            listB.Add(4);
            listB.Add(3);
            listB.Add(2);
            listB.Add(1);
            listB.Add(0);

            CustomLists<int> expected = new CustomLists<int>();
            expected.Add(0);
            expected.Add(4);
            expected.Add(1);
            expected.Add(3);
            expected.Add(2);
            expected.Add(2);
            expected.Add(3);
            expected.Add(1);
            expected.Add(4);
            expected.Add(0);
            expected.Add(5);

            myLists = myLists.ZipLists(listA, listB);


            //Assert  

            Assert.AreEqual(expected, myLists);

        }

        [Test()]
        public void ZipTwoListsStrings()
        {
            //Arrange
            CustomLists<string> myLists = new CustomLists<string>();

            CustomLists<string> listA = new CustomLists<string>();
            listA.Add("H");
            listA.Add("l");
            listA.Add("o");
            listA.Add("W");
            listA.Add("r");
            listA.Add("d");

            CustomLists<string> listB = new CustomLists<string>();
            listB.Add("e");
            listB.Add("l");
            listB.Add(" ");
            listB.Add("o");
            listB.Add("l");
            listB.Add("!");

            CustomLists<string> expected = new CustomLists<string>();
            expected.Add("H");
            expected.Add("e");
            expected.Add("l");
            expected.Add("l");
            expected.Add("o");
            expected.Add(" ");
            expected.Add("W");
            expected.Add("o");
            expected.Add("r");
            expected.Add("l");
            expected.Add("d");
            expected.Add("!");


            myLists = myLists.ZipLists(listA, listB);


            //Assert  

            Assert.AreEqual(expected, myLists);

        }
    }
}
