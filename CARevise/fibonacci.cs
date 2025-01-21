using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARevise
{
    class fibonacci
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>();
            num.Add(0);
            num.Add(1);
            //method - 1
            //for (int i = 2; i < 10; i++)
            //{
            //    int next = num[i - 1] + num[i - 2];
            //    num.Add(next);
            //}
            foreach (int a in num)
            {
                Console.Write($"{a} ");
            }

            int length = 10;
            FibonacciSeries(num,length);
        }
        //method - 2 recursive
        public static void FibonacciSeries(List<int> num, int length)
        {
            if (num.Count < length)
            {
                int next = num[num.Count - 1] + num[num.Count - 2];
                num.Add(next);
                Console.Write($"{next} ");
                FibonacciSeries(num, length);
            }
        }
    }
}
