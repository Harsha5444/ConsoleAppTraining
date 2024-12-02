//using System;

//namespace CApractice
//{
//    class Palindrome
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine($"Enter a Number: ");
//            int num = int.Parse(Console.ReadLine());
//            int input = num;
//            int revNum = 0;
//            while (num > 0)
//            {
//                int remainder = num % 10;
//                revNum = (revNum*10) + remainder;
//                num = num / 10;
//            }
//            if (input == revNum)
//                Console.WriteLine($"Given Number is a palindrome {input} - {revNum}");
//            else Console.WriteLine($"Given Number is Not a palindrome {input} - {revNum}");
//            Console.Read();
//        }
//    }
//}


using System;

namespace CAPractice
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter a Word: ");
            string word = Console.ReadLine();
            string input = word;
            string revString = "";
            Console.WriteLine(revString);
            Console.Read();

        }
    }
}