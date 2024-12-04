using System;

namespace CAtasks
{
    class Task6_JaggedArray
    {
        static void Main(string[] args)
        {
            /*---------Single dimension jagged array---------*/

            //int[][] array = new int[2][];
            //array[0] = new int[]{23,44,56 };
            //array[1] = new int[] { 22, 44 };

            //foreach (var item in array)
            //{
            //    foreach (var value in item)
            //    {
            //        Console.Write($"{value}, ");
            //    }
            //}
            //Console.Read();

            /*---------Multi dimension jagged array---------*/

            //int[][,] array = new int[2][,];
            //array[0] = new int[,] { { 1, 2 }, { 3, 4 } };
            //array[1] = new int[,] { { 5, 6 }, { 7, 8 } };

            //foreach(var item in array)
            //{
            //    foreach(var subItem in item)
            //    {
            //        Console.Write($"{subItem}, ");
            //    }
            //}
            //Console.Read();

            /*---------Dynamic multi dimension jagged array---------*/

            Console.WriteLine($"Enter size of Elements(arrays) in Jagged array: ");
            int numOfArrays = int.Parse( Console.ReadLine() );
            int[][,] array = new int[numOfArrays][,];
            for ( int i = 0; i < numOfArrays; i++ )
            {
                Console.WriteLine($"What is row size of {i + 1}th array");
                int rowSize = int.Parse(Console.ReadLine());
                Console.WriteLine($"What is Column size of {i + 1}th array");
                int colSize = int.Parse(Console.ReadLine());
                array[i]=new int[rowSize,colSize];

                Console.WriteLine($"Enter Elements in the Array{i + 1}..");
                for (int a = 0; a < rowSize; a++)
                {
                    for (int b = 0; b < colSize; b++)
                    {
                        Console.Write($"Enter Element {a + 1}x{b + 1}: ");
                        array[i][colSize,rowSize] = Convert.ToInt32(Console.ReadLine());
                    }
                }
            }
        }
    }
}
