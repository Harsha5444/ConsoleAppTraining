using System;

namespace CApractice
{
    class CalculatorMethods
    {
        // Create methods for:
        // 1. Add two numbers
        // 2. Subtract two numbers
        // 3. Multiply two numbers
        // 4. Divide two numbers

        public int Add(int a, int b)
        {
            return a + b;
        }
        public int Sub(int a, int b)
        {
            return a - b;
        }
        public int Multiply(int a, int b)
        {
            return a * b;
        }
        public int Div(int a, int b)
        {
            if (b == 0)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                return 0; // Return a default value
            }
            return a / b;
        }
    }

    class Execute
    {
        static void Main(string[] args)
        {
            CalculatorMethods calculator = new CalculatorMethods();

            int ans1 = calculator.Add(10, 30);
            int ans2 = calculator.Sub(10, 30);
            int ans3 = calculator.Multiply(10, 30);
            int ans4 = calculator.Div(10, 30);

            Console.WriteLine($"Addition: {ans1}");
            Console.WriteLine($"Subtraction: {ans2}");
            Console.WriteLine($"Multiplication: {ans3}");
            Console.WriteLine($"Division: {ans4}");

            Console.ReadLine();
        }
    }
}
