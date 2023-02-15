using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MaxGenerics<T>
    {
        // Method to find maximum by taking more than three parameters.

        public T[] array;
        public MaxGenerics(T[] array)
        {
            this.array = array;
        }
        public void TestMaximum()
        {
            FindMaxValues(array);
        }
        public static void FindMaxValues(T[] array)
        {
            int length = array.Length;
            Console.WriteLine("Length of array  is:  " + length);
            //sorting in ascending order
            Array.Sort(array);
            foreach (T item in array)
            {
                Console.Write(item + "      ");
            }
            Console.WriteLine("\nMaximum Value is: " + array[length - 1]);
        }
    }
}
