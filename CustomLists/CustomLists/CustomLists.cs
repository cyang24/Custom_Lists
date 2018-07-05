using System;
using System.Collections.Generic;

namespace CustomLists
{
    public class CustomLists<T>
    {
        public int count;
        public int arrayCount;

        private T[] array = new T[100];

        public T this[int i]
        {
            get { return array[i]; }
            set { array[i] = value; }
        }

        public T[] Array;
        public T[] temporaryArray;
       
        public CustomLists()
        {
            count = 0;
            arrayCount = 5;
            Array = new T[arrayCount];
            
        }

        public void Add(T itemToAdd)
        {
            for (int i = 0; i < arrayCount; i++)
            {
                Array[i] = array [i];
            }
            array = Array;
            Array[count] = itemToAdd;
        }
   }   
}
