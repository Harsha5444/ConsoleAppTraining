using System;

namespace CApractice
{
    class FibonacciSeries
    {
        static void Main()
        {

            Console.Write("Enter the number of terms for Fibonacci series: ");
            int n = int.Parse(Console.ReadLine());

            int first = 0, second = 1, next;

            Console.WriteLine("Fibonacci Series:");

            for (int i = 0; i < 10; i++)
            {
                if (i == 0)
                    Console.Write(first + " ");
                else if (i == 1)
                    Console.Write(second + " ");
                else
                {
                    next = first + second;
                    Console.Write(next + " ");
                    first = second;
                    second = next;
                }
            }
        }
    }
}

