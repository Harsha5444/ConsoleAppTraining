using System;

namespace CAMethods_Functions
{
    public class Method_Basics
    {
        // Simple method with no parameters and no return value
        public  void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        // Method with parameters and return value
        public  int Add(int a, int b)
        {
            return a + b;
        }

        // Method with multiple parameters of different types
        public  string FormatName(string firstName, string lastName, int age)
        {
            return $"{firstName} {lastName} is {age} years old";
        }
    }
}
