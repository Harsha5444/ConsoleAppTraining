using System;

namespace CApractice
{
    class PrimeNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine("is not a prime number");
                }
                else Console.WriteLine("is a prime number");
            }
            Console.Read();
        }
    }
}
