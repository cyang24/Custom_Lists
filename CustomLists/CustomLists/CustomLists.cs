using System;
using System.Collections.Generic;

namespace CustomLists
{
    public class CustomLists<T>
    {
        private int count = 0;
        private int capacity = 5;

        public int Capacity
        {
            get { return capacity; }
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
       
        public CustomLists()
        {
            array = new T[Capacity];
        }

        CustomLists<T> resultsList = new CustomLists<T>();

        public void Add(T item)
        {
            if (count >= capacity)
            {
                capacity += 5; 

                T[] temporaryArray = new T[capacity];

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

        public CustomLists<T> OverloadPlusOperator (CustomLists<T> listA, CustomLists<T> listB)
        {
            CustomLists<T> newCombinedLists = new CustomLists<T>();

            newCombinedLists.array = new T[listA.Count + listB.Count];

            int j = 0;

            for (int i = 0; i < listA.Count; i++)
            {
                resultsList.array[j] = listA.array[i];
                j++;
            }

            for (int i = 0; i < listB.Count; i++)
            {
                resultsList.array[j] = listB.array[i];
                j++;
            }

            return newCombinedLists;
        }

        public CustomLists<T> OverloadMinusOperator(CustomLists<T> listA, CustomLists<T> listB)
        {
            for (int i = 0; i < listA.Count; i++)
            {
                for (int j = 0; j < listB.Count; j++)
                {
                    if (listA.array[i].Equals(listB.array[j]))
                    {
                        listA.Remove(listB.array[j]);
                    }
                }
            }
            return listA;
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


        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < array.Length; i++)
            {
                yield return array[i];
            }
        }

   }   
}
