using System;

namespace CApractice
{
    class Pattern
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the number of rows: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Pattern is:");

            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} ");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
