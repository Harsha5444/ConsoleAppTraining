using System;
using System.ComponentModel.Design;

namespace CAtasks
{
    class Task5_Arrays
    {
        static void Main(String[] args)
        {
            int[,] arr = new int[3, 5]
            {
                { 1, 2, 3, 4, 5 },
                { 11, 22, 33, 44, 55 },
                { 111, 222, 333, 444, 555 }
            };

            int totalElements = arr.Length;
            int rows = arr.GetLength(0);
            int columns = arr.GetLength(1);

            Console.WriteLine($"Total elements: {totalElements}");
            Console.WriteLine($"Rows: {rows}");
            Console.WriteLine($"Columns: {columns}");

            Console.WriteLine("\nThe array elements are:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{arr[i, j]}  ");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
