using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CApractice
{
    internal class ReverseArray
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter 5 numbers: ");
            //int[] array = new int[5];
            //int[] temp = new int[5];

            //for (int i = 0; i < array.Length; i++)                       //user input
            //{
            //    array[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for (int i = 0; i < array.Length; i++)                       //copy to temp
            //{
            //    temp[i] = array[i];
            //}
            //for (int i = 0; i < array.Length; i++)                       //rever orginal unsing temp
            //{
            //    array[i] = temp[temp.Length - (i + 1)];
            //}
            //Console.Write($"Reversed Array is: ");
            //for (int i = 0; i < array.Length; i++)                       //Display reversed array
            //{
            //    Console.Write($"{array[i]} ");
            //}
            //Console.Read();



            Console.WriteLine("Enter 5 numbers: ");
            int[] array = new int[5];

            // User input
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Reverse the array in place
            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
            }

            // Display the reversed array
            Console.Write("Reversed Array is: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"{array[i]} ");
            }

            Console.Read();

        }
    }
}


