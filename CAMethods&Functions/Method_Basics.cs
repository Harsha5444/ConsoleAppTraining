using System;

namespace CAMethods_Functions
{
    public class Method_Basics
    {
        // Simple method with no parameters and no return value
        public static void SayHello()
        {
            Console.WriteLine("Hello!");
        }

        // Method with parameters and return value
        public static int Add(int a, int b)
        {
            return a + b;
        }

        // Method with multiple parameters of different types
        public static string FormatName(string firstName, string lastName, int age)
        {
            return $"{firstName} {lastName} is {age} years old";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Call the static method directly using the class name
            Method_Basics.SayHello();

            // Create an instance to call non-static methods
            Method_Basics methods = new Method_Basics();

            //// Call Add method
            //int result = methods.Add(5, 10);
            //Console.WriteLine($"Addition result: {result}");

            //// Call FormatName method
            //string formattedName = methods.FormatName("John", "Doe", 30);
            //Console.WriteLine(formattedName);

            Console.Read();
        }
    }
}
