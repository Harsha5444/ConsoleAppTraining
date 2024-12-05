using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApractice
{
    internal class ArraysandSearching
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter the Size of the array: ");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] array = new int[size];

            Console.WriteLine($"Enter {size} Numbers: ");
            for (int i = 0; i < size; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Sort the array before binary search
            Array.Sort(array);

            begin:
            Console.WriteLine($"Enter a number to search (-1 to exit): ");
            int number = Convert.ToInt32(Console.ReadLine());

            int start = 0;
            int end = array.Length - 1;

            while (true)
            {
                if (number == -1)  // Check for exit condition
                {
                    Console.WriteLine("Exiting the search...");
                    break;
                }

                int middle = (start + end) / 2;

                if (array[middle] == number)
                {
                    Console.WriteLine($"{number} found at index {middle}.\n");
                    goto begin;
                }
                else if (array[middle] > number)
                {
                    end = middle - 1;  // Search in the left half
                }
                else if (array[middle] < number)
                {
                    start = middle + 1;  // Search in the right half
                }

                // Exit condition if the number is not found
                if (start > end)
                {
                    Console.WriteLine($"{number} is not found in the array.\n");
                    goto begin;
                }
            }
            Console.Read();

        }
    }
}
