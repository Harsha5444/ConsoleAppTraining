using System;

class ArithmeticOperations
{
    static void Main()
    {
        // Basic arithmetic operators
        int a = 10;
        int b = 3;

        // Addition (+)
        int sum = a + b;        // Results in 13

        // Subtraction (-)
        int difference = a - b;  // Results in 7

        // Multiplication (*)
        int product = a * b;    // Results in 30

        // Division (/)
        // Important: Division behavior differs based on operand types
        int quotient = a / b;   // Results in 3 (not 3.333... because it's integer division)
        double exactQuotient = (double)a / b;  // Results in 3.333... (type casting for floating-point division)

        // Modulus (%) - Returns the remainder
        int remainder = a % b;  // Results in 1

        // Increment (++) and Decrement (--)
        int x = 5;
        x++;    // Post-increment: use x, then add 1
        ++x;    // Pre-increment: add 1, then use x
        x--;    // Post-decrement: use x, then subtract 1
        --x;    // Pre-decrement: subtract 1, then use x

        // The difference between pre and post increment
        int y = 5;
        int z1 = y++;  // z1 gets 5, then y becomes 6
        y = 5;         // Reset y
        int z2 = ++y;  // y becomes 6, then z2 gets 6

        //-----------------------------------------------------------------------------------------//

        //Compound Assignment Operators:
        //These operators combine arithmetic with assignment
        int number = 10;
        number += 5;   // Same as: number = number + 5
        number -= 3;   // Same as: number = number - 3
        number *= 2;   // Same as: number = number * 2
        number /= 4;   // Same as: number = number / 4
        number %= 3;   // Same as: number = number % 3

        //Comparison Operators:
        //These operators return boolean values(true / false):
        //int x = 5;
        //int y = 10;

        //bool isEqual = x == y;          // Equal to (false)
        //bool isNotEqual = x != y;       // Not equal to (true)
        //bool isGreater = x > y;         // Greater than (false)
        //bool isLess = x < y;            // Less than (true)
        //bool isGreaterOrEqual = x >= y; // Greater than or equal to (false)
        //bool isLessOrEqual = x <= y;    // Less than or equal to (true)


        //Logical Operators:
        //Used to combine boolean conditions:
        bool condition1 = true;
        bool condition2 = false;

        bool andResult = condition1 && condition2;  // Logical AND (true only if both are true)
        bool orResult = condition1 || condition2;   // Logical OR (true if either is true)
        bool notResult = !condition1;              // Logical NOT (inverts the boolean value)

        // Short-circuit evaluation
        // In &&, if first condition is false, second isn't evaluated
        // In ||, if first condition is true, second isn't evaluated
        //bool result = (GetValue() > 0) && (PerformCalculation() != 0);

        //Bitwise Operators:
        //These operate on individual bits of integer values:
        //int a = 5;     // Binary: 0101
        //int b = 3;     // Binary: 0011

        //int bitwiseAnd = a & b;   // Binary AND: 0001 (1)
        //int bitwiseOr = a | b;    // Binary OR:  0111 (7)
        //int bitwiseXor = a ^ b;   // Binary XOR: 0110 (6)
        //int bitwiseNot = ~a;      // Binary NOT: 1111...1010
        //int leftShift = a << 1;   // Left shift:  1010 (10)
        //int rightShift = a >> 1;  // Right shift: 0010 (2)

        //Type Conversion and Casting:
        //Understanding type conversion is crucial when working with operators:
        // Implicit conversion (automatic, no data loss)
        int intNum = 100;
        long longNum = intNum;      // int fits inside long
        float floatNum = intNum;    // int fits inside float

        // Explicit conversion (casting, possible data loss)
        double doubleNum = 123.456;
        int convertedInt = (int)doubleNum;    // Truncates to 123

        // String conversion
        string numString = "123";
        int parsedInt = int.Parse(numString);
        // Or more safely:
        int parsedNumber;
        bool success = int.TryParse(numString, out parsedNumber);
    }
}