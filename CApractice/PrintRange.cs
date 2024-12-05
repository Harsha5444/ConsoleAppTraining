using System;
using System.Collections.Generic;
using System.Linq;
namespace CAPractice
{
    class PrintRange
    {
        static void Main(string[] args)
        {
            IEnumerable<int> oddNums =

                Enumerable.Range(20, 20).Where(x => x % 2 == 0);

            foreach (int n in oddNums)
            {
                Console.WriteLine(n);
            }
            Console.ReadLine();

        }
    }
}
