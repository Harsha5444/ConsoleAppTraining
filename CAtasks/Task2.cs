using System;

namespace CAPractice
{
    class Task2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any 5 Numbers: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int num3 = Convert.ToInt32(Console.ReadLine());
            int num4 = Convert.ToInt32(Console.ReadLine());
            int num5 = Convert.ToInt32(Console.ReadLine());

            int smallNum = num1;
            int bigNum = num2;

            if (smallNum > num2)
            {
                smallNum = num2;
            }
            if (smallNum > num3)
            {
                smallNum = num3;
            }
            if (smallNum > num4)
            {
                smallNum = num4;
            }
            if (smallNum > num5)
            {
                smallNum = num5;
            }
            if (bigNum < num1)
            {
                bigNum = num1;
            }
            if (bigNum < num3)
            {
                bigNum = num3;
            }
            if (bigNum < num4)
            {
                bigNum = num4;
            }
            if (bigNum < num5)
            {
                bigNum = num5;
            }
            Console.WriteLine($"biggest Number is {bigNum}");
            Console.WriteLine($"Smallest Number is {smallNum}");
            Console.Read();
        }
    }
}
