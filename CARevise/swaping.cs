using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CARevise
{
    class swaping
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 20;
            Console.WriteLine("before swap " + "a = "+a+" b = "+b);
            int c = a;
            a = b;
            b = c;
            Console.WriteLine("after swap " + "a = " + a + " b = " + b);
            a *= b;
            b = a / b;
            a = a / b;
            Console.WriteLine("after swap " + "a = " + a + " b = " + b);
            a += b;
            b = a - b;
            a = a - b;
            Console.WriteLine("after swap " + "a = " + a + " b = " + b);
            string s1 = "One";
            string s2 = "Two";
            Console.WriteLine("\n\nbefore swap " + "String1 = " + s1 + " String2 = " + s2);
            s1 += s2;
            s2 = s1.Substring(0,s1.Length-s2.Length);
            s1 = s1.Substring(s2.Length);
            Console.WriteLine("after swap " + "String1 = " + s1 + " String2 = " + s2);
        }
    }
}
