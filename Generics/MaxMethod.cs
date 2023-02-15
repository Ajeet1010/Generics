using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class MaxMethod
    {
        // Method to find maximum by taking more than three parameters.
        
        public static void Maximum(int[] array)
        {
            int length = array.Length;
            Console.WriteLine("Length of array for int is:  " + length);
            Array.Sort(array);
            Console.Write("Input is: ");
            foreach (int item in array)
                Console.Write(item + " ");
            Console.WriteLine("\nMaximum Value is: " + array[length - 1]);
        }
        public static void Maximum(float[] array)
        {
            int length = array.Length;
            Console.WriteLine("\n\nLength of array for float is:  " + length);
            Array.Sort(array);
            Console.Write("Input is: ");
            foreach (float item in array)
                Console.Write(item + " ");
            Console.WriteLine("\nMaximum Value is: " + array[length - 1]);
        }
        public static void Maximum(string[] array)
        {
            int length = array.Length;
            Console.WriteLine("\n\nLength of array for string is:  " + length);
            Array.Sort(array);
            Console.Write("Input is: ");
            foreach (string item in array)
                Console.Write(item + " ");
            Console.WriteLine("\nMaximum Value is: " + array[length - 1]);
        }
    }
}
