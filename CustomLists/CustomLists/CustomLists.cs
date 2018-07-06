using System;
using System.Collections.Generic;

namespace CustomLists
{
    public class CustomLists<T>
    {
        private int count = 0;
        private int capacity;

        public int Capacity
        {
            get { return capacity; }
            set { capacity = value; }
        }

        public int Count
        {
            get { return count; }
            set { count = value; }
        }

        private T[] array;

        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }
       
        public CustomLists()
        {
            Count = 0;
            Capacity = 5;
            array = new T[Capacity];
        }

        public void Add(T item)
        {
            if (count >= capacity)
            {
                capacity += 5;  
                T[] newArray = new T[capacity];

                for (int i = 0; i < count; i++)
                {
                    newArray[i] = array[i];
                }

                array = newArray;
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
                    Count--;
                    return true;
                }

            return false;
        }
   }   
}
