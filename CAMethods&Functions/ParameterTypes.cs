using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAMethods_Functions
{
    public class ParameterTypes
    {
        // Value parameters (pass by value)
        public static void IncrementNumber(int number)
        {
            number++; // Original value remains unchanged
        }

        // Reference parameters (ref keyword)
        public static void IncrementNumberRef(ref int number)
        {
            number++; // Original value is modified
        }

        // Output parameters (out keyword)
        public static void GetValues(out int x, out int y)
        {
            x = 4560; // Must assign value
            y = 89670; // Must assign value
        }

        // Parameter arrays (params keyword)
        public static int Sum(params int[] numbers)
        {
            int total = 0;
            foreach (int num in numbers)
            {
                total += num;
            }
            return total;
        }

        // Optional parameters
        public static void DisplayInfo(string name, int age = 30, string city = "Unknown")
        {
            Console.WriteLine($"{name}, {age}, from {city}");
        }

        // Named arguments
        public static void Example()
        {
            DisplayInfo(city: "New York", name: "John", age: 25);
        }
    }
}
