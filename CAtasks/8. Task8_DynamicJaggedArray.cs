using System;

namespace CAtasks
{
    internal class Task8_DynamicJaggedArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of 2D arrays for the jagged array:");
            int numOfArrays = int.Parse(Console.ReadLine());
            int[][,] jaggedArray = new int[numOfArrays][,];

            for (int i = 0; i < numOfArrays; i++)
            {
                Console.WriteLine($"Enter the dimensions for 2D Array {i + 1}:");
                Console.Write("Number of rows: ");
                int rowSize = int.Parse(Console.ReadLine());
                Console.Write("Number of columns: ");
                int colSize = int.Parse(Console.ReadLine());

                jaggedArray[i] = new int[rowSize, colSize];

                Console.WriteLine($"Enter the elements for 2D Array {i + 1}:");
                for (int row = 0; row < rowSize; row++)
                {
                    for (int col = 0; col < colSize; col++)
                    {
                        Console.Write($"Element [{row + 1}, {col + 1}]: ");
                        jaggedArray[i][row, col] = int.Parse(Console.ReadLine());
                    }
                }
            }

            Console.WriteLine("\nThe 2D arrays in the jagged array are:");
            int arrayIndex = 1;

            foreach (var array in jaggedArray)
            {
                Console.WriteLine($"\n2D Array {arrayIndex++}:");
                for (int row = 0; row < array.GetLength(0); row++)
                {
                    for (int col = 0; col < array.GetLength(1); col++)
                    {
                        Console.Write($"{array[row, col]} ");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine(new string('-', 20));
            }
            Console.Read(); 
        }
    }
}
