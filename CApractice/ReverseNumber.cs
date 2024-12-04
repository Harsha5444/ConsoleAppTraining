using System;

namespace CApractice
{
    class ReverseNumber
    {
        static void Main(string[] args)
        {
            Console.Write($"Enter a Number: ");
            long num = long.Parse(Console.ReadLine());
            long input = num;
            long revNum = 0;
            while (num > 0)
            {
                long remainder = num % 10;
                revNum = (revNum * 10) + remainder;
                num = num / 10;
            }
            //if (input == revNum)
            //    Console.WriteLine($"Given Number is a palindrome {input} - {revNum}");
            //else Console.WriteLine($"Given Number is Not a palindrome {input} - {revNum}");
            Console.WriteLine($"Reverse Of Given Number is {revNum}");
            Console.Read();
        }
    }
}
