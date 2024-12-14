using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAtasks
{
    internal class Task9_OperatorOverloading
    {
        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }

            // Overloading the + operator
            public static Point operator +(Point p1, Point p2)
            {
                return new Point(p1.X + p2.X, p1.Y + p2.Y);
            }

            // Overloading the - operator
            public static Point operator -(Point p1, Point p2)
            {
                return new Point(p1.X - p2.X, p1.Y - p2.Y);
            }

            // Overriding ToString for better display
            public override string ToString()
            {
                return $"({X}, {Y})";
            }
        }

        static void Main(string[] args)
        {
            Point p1 = new Point(3, 4);
            Point p2 = new Point(1, 2);

            Point sum = p1 + p2; // Uses the overloaded + operator
            Point difference = p1 - p2; // Uses the overloaded - operator

            Console.WriteLine($"Point 1: {p1}");
            Console.WriteLine($"Point 2: {p2}");
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Difference: {difference}");
        }
    }
}
