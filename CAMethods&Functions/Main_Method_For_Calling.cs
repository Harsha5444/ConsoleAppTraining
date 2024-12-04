using System;

namespace CAMethods_Functions
{
    class Main_Method_For_Calling
    {
        static void Main(string[] args)
        {
            /*----------------------Methods from Method_Basics----------------------*/

            //Method_Basics.SayHello();

            //int sum = Method_Basics.Add(4,5);
            //Console.WriteLine($"\n{sum}");

            //string name = Method_Basics.FormatName("harsha", "vardhan", 23);
            //Console.WriteLine(name);


            /*-----------Methods from ParameterTypes-----------*/

            //int num = 32;
            //Console.WriteLine(num);
            //ParameterTypes.IncrementNumber(num);
            //Console.WriteLine(num);


            //int num1 = 32;
            //Console.WriteLine(num1);
            //ParameterTypes.IncrementNumberRef(ref num1);
            //Console.WriteLine(num1);


            //ParameterTypes.GetValues(out int x, out int y);
            //Console.WriteLine(x);
            //Console.WriteLine(y);


            //int sum = ParameterTypes.Sum(23, 25);
            //Console.WriteLine(sum);

            //ParameterTypes.DisplayInfo("harsha", 23, "huderabad");

            //ParameterTypes.Example();


            /*-----------Methods from MethodOverloading-----------*/

            //int sum = Calculator.Add(12, 13);
            //Console.WriteLine(sum);

            //double sum1 = Calculator.Add(12.45, 13.76);
            //Console.WriteLine(sum1);

            //string concat = Calculator.Add("harsha", "vardhan");
            //Console.WriteLine(concat);

            //int sum2 = Calculator.Add(12, 13, 14);
            //Console.WriteLine(sum2);

            /*-----------Methods from MordernSyntax-----------*/

            //int cross = ModernSyntax.Multiply(4, 4);
            //Console.WriteLine(cross);

            //int cross1 = ModernSyntax.MultiplyExpression(4, 0);
            //Console.WriteLine(cross1);

            //string name = ModernSyntax.Name;
            //Console.WriteLine(name);

            //ModernSyntax.Age = 25;  // Setting age
            //Console.WriteLine(ModernSyntax.Age);  // Output: 25

            //ModernSyntax.Age = -5;  // Setting an invalid age
            //Console.WriteLine(ModernSyntax.Age);  // Output: 0

            /*-----------Methods from MethodInsideMethod-----------*/

            //int[] numbers = { -1, 2 };

            //int sum = LocalFunctionExample.CalculateTotal(numbers);
            //Console.WriteLine(sum);

            /*-----------Methods from MethodInsideMethod-----------*/

            //string text = "Hello world! This is a test.";

            //// Call the extension method WordCount on the text string
            //int wordCount = text.WordCount();

            //Console.WriteLine($"Word count: {wordCount}");  // Output will be 5

            /*-----------------------------------------------------*/

            Console.Read();
        }
    }
}
