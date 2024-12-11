using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApractice
{
    class ArrayHelper
    {
        // Create methods to:
        // 1. Find the largest number in an array
        // 2. Calculate average of array elements
        // 3. Count even numbers in array
        // 4. Print all elements

        public void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
        public int largestnum(int[] arr)
        {
            int num = arr.Max(); //using LINQ
            return num;
        }
        public double average(int[] arr)
        {
            double avg = arr.Average(); //using LINQ
            return avg;
        }
        public int evenNum(int[] arr)
        {
            int count = arr.Count(num => num % 2 == 0);
            return count;
        }
    }
    class arrayhelper
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            ArrayHelper arrayHelper = new ArrayHelper();
            arrayHelper.PrintArray(arr);
            Console.WriteLine(arrayHelper.largestnum(arr));
            Console.WriteLine(arrayHelper.average(arr));
            Console.WriteLine(arrayHelper.evenNum(arr));
        }
    }       
}
