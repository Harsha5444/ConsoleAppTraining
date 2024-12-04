using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAMethods_Functions
{
    public class ModernSyntax
    {
        // Traditional method
        public static int Multiply(int a, int b)
        {
            return a * b;
        }

        // Expression-bodied method (same functionality)
        public static int MultiplyExpression(int a, int b) => a * b;

        // Expression-bodied property
        public static string Name => "John Doe";

        // Expression-bodied getter/setter
        private static int age;
        public static int Age
        {
            get => age;
            set => age = value < 0 ? 0 : value;
        }
    }
}
