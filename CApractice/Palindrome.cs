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
using System.Linq;

namespace CAPractice
{
    class Palindrome
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Enter a Word: ");
            string word = Console.ReadLine();
            //string revString = "";
            //for (int i = word.Length - 1; i >= 0; i--)
            //{
            //    Console.Write($"{word[i]}");
            //    revString += word[i];
            //}
            //if (revString == word)
            //{
            //    Console.WriteLine("\npalindrome");
            //}
            //else Console.WriteLine("not a ");
            //Console.Read();

            
        }
    }
}