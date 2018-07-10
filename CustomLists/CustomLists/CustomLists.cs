using System;
using System.Collections;
using System.Collections.Generic;


namespace CustomLists
{
    public class CustomLists<T> : IEnumerable 
    {
        private int count;
        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set {  capacity = value; }
        }

        public int Count
        {
            get { return count; }
        }

        private T[] array;

        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
        public T[] temporaryArray;

        public CustomLists()
        {
            
            count = 0;
            capacity = 5;
            array = new T[capacity];
        }

       

        public void Add(T item)
        {
            if (count >= capacity)
            {
                capacity += count;

                temporaryArray = new T[capacity];

                for (int i = 0; i < count; i++)
                {
                    temporaryArray[i] = array[i];
                }

                array = temporaryArray;
                array[count] = item;
                count++;
            }

            else
            {
                array[count] = item;
                count++;
            }
        }

        public bool Remove(T itemToRemove)
        {
            for (int i = 0; i < count; i++)
                if (array[i].Equals(itemToRemove))
                {
                    while (i < count)
                    {
                        array[i] = array[i + 1];
                        i++;
                    }
                    count--;

                    return true;
                }

            return false;
        }

        public override string ToString()
        {
            string item = "";
            foreach (T value in array)
            {
                item += value;
            }

            return item;
        }


        public CustomLists<T> OverloadPlusOperator (CustomLists<T> listA, CustomLists<T> listB) // Overload Plus Operator needs two seperate list of the same data type to be passed in the parameter.
        {
        CustomLists<T> newCombinedLists = new CustomLists<T>();                                 // list of the same data type is instantiated and declared

        newCombinedLists.array = new T[listA.Count + listB.Count];                              // new instantiated list is set to the size of the two list being passed 

            for (int i = 0; i > listA.Count; i++)                                               // new combined list loops and adds all List A items
            {
                newCombinedLists[i] = listA[i];
            }

            for (int i = 0; i > listB.Count; i++)                                               // new combined list loops and adds all List B items
            {
                newCombinedLists[i] = listA[i];
            }

            return newCombinedLists;                                                            // new combined list is returned with combined Lists A&B
        }

        public CustomLists<T> OverloadMinusOperator(CustomLists<T> listA, CustomLists<T> listB) // Overload Minus Operator needs two seperate list of the same data type to be passed in the parameter.
        {
            for (int i = 0; i < listA.Count; i++)                                               // for loop sets conditons and loops through the size of of first list being passed
            {
                for (int j = 0; j < listB.Count; j++)                                           // secondary for loop sets conditons and loops through second list being passed
                {
                    if (listA.array[i].Equals(listB.array[j]))                                  // if statement creates boolean condition for removal 
                    { 
                        listA.Remove(listB.array[j]);                                           // All true matches are are removed and stored on the stack and repeated until loops finishes
                    }
                }
            }
        return listA;                                                                           // stack unwinds and a returns remaining list of non matching values
        }

        public CustomLists<T> ZipLists(CustomLists<T> listA, CustomLists<T> listB)
        {
            CustomLists<T> zipLists = new CustomLists<T>();

            zipLists.array = new T[listA.Count + listB.Count];

            int j = 0;

            for (int i = 0; i < listA.Count; i++)
            {
                zipLists.array[j] = listA.array[i];
                j++;

                zipLists.array[j] = listB.array[i];
                j++;
            }
            return zipLists;
        }

        public IEnumerator GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }

   }   
}
