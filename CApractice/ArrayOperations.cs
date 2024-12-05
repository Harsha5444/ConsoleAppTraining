using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApractice
{
    internal class ArrayOperations
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter 10 Numbers: ");
            int[] array = new int[10];
            int sumOfEven = 0;
            int maxNumber = int.MinValue;
            int minNumber = int.MaxValue;
            int indexOfMinnumber = 0;
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0;i < array.Length; i++)
            {
                if(array[i] % 2 == 0)
                {
                    sumOfEven += array[i];
                }

                if(array[i] > maxNumber)
                {
                    maxNumber = array[i];
                }

                if (array[i] < minNumber)
                {
                    minNumber = array[i];
                }
            }

            for(int i = 0;i<array.Length; i++)
            {
                if (array[i] == minNumber)
                {
                    indexOfMinnumber = i;
                }
            }
            Console.WriteLine($"The sum of all even numbers in the array: {sumOfEven}");
            Console.WriteLine($"The maximum number in the array: {maxNumber}");
            Console.WriteLine($"The index of the minimum number in the array: {indexOfMinnumber}");
            Console.Read();

        }
    }
}
