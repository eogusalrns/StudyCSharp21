﻿using System;

namespace GenericClassApp
{
    class Array_Generic<T>
    {
        private T[] array;

        public Array_Generic()
        {
            array = new T[10];
        }

        //public void SetElement
        public T GetElement(int index) { return array[index];
        }

        public int Length{ get { return array.Length; } }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Array_Generic<int> array = new Array_Generic<int>();
            Array_Generic<string> strArr = new Array_Generic<string>();  
        }
    }
}
