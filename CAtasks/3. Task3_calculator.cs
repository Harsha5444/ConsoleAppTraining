using System;

namespace CAtasks
{
    class Task3_calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First Number: ");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operator: ");
            char Operator = Convert.ToChar(Console.ReadLine());
            if (Operator == '+' | Operator == '-' | Operator == '*' | Operator == '/')
            {
                Console.WriteLine("Enter Second Number: ");
                int secondNumber = Convert.ToInt32(Console.ReadLine());
                if (Operator == '/' & secondNumber == 0)
                {
                    Console.WriteLine("Error: Denominator Cannot be Zero(0) When Performing Division(/)..!");
                }

                double result = 0;

                if (Operator == '+')
                {
                    result = firstNumber + secondNumber;
                }
                else if (Operator == '-')
                {
                    result = firstNumber - secondNumber;
                }
                else if (Operator == '*')
                {
                    result = firstNumber * secondNumber;
                }
                else if (Operator == '/')
                {
                    result = (double)firstNumber / secondNumber; // Ensure division is precise
                }
            }
            else Console.WriteLine("Error: Please Enter A Valid Operator(+, -, *, /)");
            Console.ReadLine();
        }
    }
}
