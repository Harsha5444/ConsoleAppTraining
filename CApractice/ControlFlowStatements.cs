//using System;

//namespace CApractice
//{
//    class ControlFlowStatements
//    {
//        static void Main(string[] args)
//        {
//            int age = 20;

//            // Simple if
//            if (age >= 18)
//            {
//                Console.WriteLine("You are an adult");
//            }

//            // if-else
//            if (age >= 18)
//            {
//                Console.WriteLine("You are an adult");
//            }
//            else
//            {
//                Console.WriteLine("You are a minor");
//            }

//            // if-else if-else (multiple conditions)
//            if (age < 13)
//            {
//                Console.WriteLine("Child");
//            }
//            else if (age < 20)
//            {
//                Console.WriteLine("Teenager");
//            }
//            else
//            {
//                Console.WriteLine("Adult");
//            }

//            // Nested if statements
//            if (age >= 18)
//            {
//                if (age < 65)
//                {
//                    Console.WriteLine("Working age adult");
//                }
//            }

//            // Ternary operator (shorthand if-else)
//            string status = (age >= 18) ? "Adult" : "Minor";
//        }
//    }
//}



//using System;

//namespace CApractice
//{
//    class ControlFlowStatements
//    {
//        static void Main(string[] args)
//        {
//            int dayNumber = 3;

//            // Traditional switch
//            switch (dayNumber)
//            {
//                case 1:
//                    Console.WriteLine("Monday");
//                    break;
//                case 2:
//                    Console.WriteLine("Tuesday");
//                    break;
//                case 3:
//                    Console.WriteLine("Wednesday");
//                    break;
//                default:
//                    Console.WriteLine("Invalid day");
//                    break;
//            }

//            // Switch expression (C# 8.0+)
//            //string day = dayNumber switch
//            //{
//            //    1 => "Monday",
//            //    2 => "Tuesday",
//            //    3 => "Wednesday",
//            //    _ => "Invalid day"
//            //};

//            // Pattern matching with switch
//            object obj = "Hello";
//            switch (obj)
//            {
//                case string s when s.Length > 0:
//                    Console.WriteLine($"String: {s}");
//                    break;
//                case int n:
//                    Console.WriteLine($"Integer: {n}");
//                    break;
//                case null:
//                    Console.WriteLine("Null value");
//                    break;
//                default:
//                    Console.WriteLine("Unknown type");
//                    break;
//            }
//        }
//    }
//}




using System;

namespace CApractice
{
    class ControlFlowStatements
    {
        static void Main(string[] args)
        {
            // For Loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Iteration {i}");
            }

            // While Loop
            int counter = 0;
            while (counter < 5)
            {
                Console.WriteLine($"Count: {counter}");
                counter++;
            }

            // Do-While Loop (executes at least once)
            int number = 0;
            do
            {
                Console.WriteLine($"Number is {number}");
                number++;
            } while (number < 3);

            // Foreach Loop (for collections)
            string[] fruits = { "apple", "banana", "orange" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // Nested Loops
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"i: {i}, j: {j}");
                }
            }
        }
    }
}