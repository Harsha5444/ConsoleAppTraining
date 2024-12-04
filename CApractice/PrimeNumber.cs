using System;

namespace CApractice
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            start:
            Console.WriteLine("Enter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
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
            goto start;
        }
    }
}
