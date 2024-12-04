using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAMethods_Functions
{
    public class LocalFunctionExample
    {
        public static int CalculateTotal(int[] numbers)
        {
            // Local function
            bool IsValid(int number)
            {
                return number >= 0;
            }

            int total = 0;
            foreach (int number in numbers)
            {
                if (IsValid(number))
                {
                    total += number;
                }
            }
            return total;
        }
    }
}
