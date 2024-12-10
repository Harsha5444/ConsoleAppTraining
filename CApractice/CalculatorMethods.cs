using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public int Sub(int a , int b)
        {
            return (a - b);
        }
        public int Mutiply(int a , int b)
        {
            return (a * b);
        }
        public int div(int a , int b)
        {
            return (a / b);
        }
    }

    class execute
    {
        static void Main(string[] args)
        {
            CalculatorMethods addition = new CalculatorMethods();
            CalculatorMethods subtraction = new CalculatorMethods();
            CalculatorMethods multiplication = new CalculatorMethods();
            CalculatorMethods division = new CalculatorMethods();
            int ans1 = addition.Add(10, 30);
            subtraction.Sub(10, 30);
            multiplication.Mutiply(10, 30); 
            division.div(10, 30);
            Console.WriteLine(ans1);
            Console.Read();
        }
    }
}
