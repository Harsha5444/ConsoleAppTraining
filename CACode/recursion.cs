using System;
namespace CACode
{
    class recursion
    {
        static void Main(string[] args)
        {
            int number = 5;
            int Result = fun(number);
            Console.WriteLine(Result);
            Console.ReadKey();
        }
        static int fun(int n)
        {
            if (n > 0)
            {
                return fun(n - 1) + n;
            }
            return 0;
        }
    }
}