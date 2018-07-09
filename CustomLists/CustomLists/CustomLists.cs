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
        z
        public OverloadPlusOperator (CustomLists<T> listA, CustomLists<T> listB)
        {
            CustomLists<T> newCombinedLists = new CustomLists<T>();
            newCombinedLists.Array = new T[listA.Count + listB.Count];

            int j = 0;

            for (int i = 0; i < listA.Count; i++)
            {
                resultList.Array[j] = listA.Array[i];
                j++;
            }
            for (int i = 0; i < listB.Count; i++)
            {
                resultList.Array[j] = listB.Array[i];
                j++;
            }

            return newCombinedLists;
        }

        public OverloadMinusOperator(CustomLists<T> listA, CustomLists<T> listB)
        {
            for (int i = 0; i < listA.Count(); i++)
            {
                for (int j = 0; j < listB.Count(); j++)
                {
                    if (listA.array[i].Equals(listB.array[j]))
                    {
                        listA.RemoveAt(listB.array[j]);
                    }
                }
            }
            return listA;
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
