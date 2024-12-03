using System;
using System.ComponentModel.Design;

namespace CAtasks
{
    class Task5_Arrays_1
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Choose Which Type Of Array You Want To Store Your Numbers in...!");
            Selection:
            Console.WriteLine($"1. One Dimensional Array\n2. Two Dimensional Array\nPress 1 or 2 to Continue...");
            short type = Convert.ToInt16(Console.ReadLine());
            if (type == 1)
            {
                Console.WriteLine($"Enter Size Of One Dimensional Array: ");
                int size = Convert.ToInt32(Console.ReadLine());
                int[] array = new int[size];
                Console.WriteLine($"Enter Elements In The One Dimensional Array: ");
                for (int i = 0; i < size; i++)
                {
                    Console.Write("Enter Element - " + (i + 1) + ":");
                    array[i] = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine();
                }
                Console.WriteLine("Elements of Array are: ");
                foreach (var item in array)
                {
                    Console.Write(item + ", ");
                }
            }
            else if (type == 2)
            {
                Console.WriteLine($"Enter Size Of Two Dimensional Array in Row/Col...! ");
                Console.WriteLine($"Enter Row Size Of Two Dimensional Array: ");
                int rowSize = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Enter Column Size Of Two Dimensional Array: ");
                int colSize = Convert.ToInt32(Console.ReadLine());
                int[,] array = new int[rowSize, colSize];
                Console.WriteLine($"Enter Elements in the Array..");
                for (int i = 0; i < rowSize; i++)
                {
                    for (int j = 0; j < colSize; j++)
                    {
                        Console.Write($"Enter Element {i + 1}x{j + 1}: ");
                        array[i, j] = Convert.ToInt32(Console.ReadLine());
                    }
                }
                Console.WriteLine("Elements of Array are: ");
                for (int i = 0; i < rowSize; i++)
                {
                    for (int j = 0; j < colSize; j++)
                    {
                        Console.Write(array[i, j] + "  ");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine($"Please Select Valid Array Dimension From the Given Option's");
                goto Selection;
            }
            Console.Read();
        }
    }
}
