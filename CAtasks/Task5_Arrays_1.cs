using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAtasks
{
    internal class Task5_Arrays_1
    {
        static void Main(string[] args)
        {
            int[,] ar = new int[3, 4] { { 12, 34, 45, 56 }, { 45, 56, 78, 98 }, { 12, 32, 43, 54 } };

            Console.WriteLine("Elements of Array are: ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(ar[i, j] + "  ");
                }
                Console.WriteLine();
            }

            Console.Read();
        }
    }
}
