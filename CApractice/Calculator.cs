using System;
namespace CApractice
{
    class Calculator
    {
        static void Main()
        {
            Console.WriteLine("Enter first number:");
            int firstNum = int.Parse(Console.ReadLine());


            Console.WriteLine("Enter second number:");
            int secondNum = int.Parse(Console.ReadLine());

            // Using string interpolation
            Console.WriteLine($"Addition Of Numbers: {firstNum + secondNum}");
            Console.WriteLine($"Subtraction Of Numbers: {firstNum - secondNum}");
            Console.WriteLine($"Multiplication Of Numbers: {firstNum * secondNum}");
            Console.WriteLine($"Division Of Numbers: {firstNum / secondNum}");
            Console.WriteLine($"Remainder : {firstNum % secondNum}");
            // Remember to handle potential errors!

            bool isEqual = firstNum == secondNum;          // Equal to (false)
            bool isNotEqual = firstNum != secondNum;       // Not equal to (true)
            bool isGreater = firstNum > secondNum;         // Greater than (false)
            bool isLess = firstNum < secondNum;            // Less than (true)
            bool isGreaterOrEqual = firstNum >= secondNum; // Greater than or equal to (false)
            bool isLessOrEqual = firstNum <= secondNum;    // Less than or equal to (true)

            Console.WriteLine($"firstNum == secondNum {isEqual}");
            Console.WriteLine($"firstNum != secondNum {isNotEqual}");
            Console.WriteLine($"firstNum > secondNum  {isGreater}");
            Console.WriteLine($"firstNum < secondNum  {isLess}");
            Console.WriteLine($"firstNum >= secondNum {isGreaterOrEqual}");
            Console.WriteLine($"firstNum <= secondNum {isLessOrEqual}");




            Console.ReadLine();
        }
    }
}


/*EfirstNumercise: Calculator Program
Create a console application that:

Asks the user for two numbers
Performs all arithmetic operations (+, -, *, /, %)
Compares the numbers using all comparison operators
Demonstrates bitwise operations
Shows the difference between integer and floating-point division
Handles potential errors (like division bsecondNum zero)*/
