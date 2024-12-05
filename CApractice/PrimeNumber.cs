using System;
using System.IO;

namespace CApractice
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a number (-1 to exit): ");
                int num = Convert.ToInt32(Console.ReadLine());
                if (num == -1)
                {
                    Console.WriteLine($"Goodbye!");
                    break;
                }
                else if (num > 0)
                {
                    if (num < 2) Console.WriteLine($"{num} is not a prime number.");
                    else if (num == 2) Console.WriteLine($"{num} is a prime number.");
                    else
                    {
                        bool set = true;
                        for (int i = 2; i <= Math.Sqrt(num); i++)
                        {
                            if (num % i == 0)
                            {
                                set = false;
                                break;
                            }
                        }
                        if (set) Console.WriteLine($"{num} is a prime number.");
                        else Console.WriteLine($"{num} is not a prime number.");
                    }
                    Console.WriteLine();
                }
            }
            Console.Read();
        }
    }
}
