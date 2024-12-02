/*Exercise: Number Analysis Program
Create a program that:

Asks the user to input numbers until they enter -1
For each number:

Determine if it's positive, negative, or zero
Check if it's even or odd
If it's positive, determine if it's prime


Keep track of:

The count of numbers entered
The sum of all numbers
The largest and smallest numbers


After -1 is entered:

Display all statistics
Calculate and show the average
Show how many numbers were even/odd

Key points to focus on:

Use appropriate loops for continuous input
Use if/else for number analysis
Consider using switch statements where appropriate
Implement break when -1 is entered
Use methods to organize your code
Handle invalid inputs
Format your output clearly
*/

using System;
namespace CApractice
{
    class NumberAnalysis
    {
        static void Main()
        {
            int count = 0;
            int sum = 0;
            int largest = int.MinValue;
            int smallest = int.MaxValue;
            int evenCount = 0;
            int oddCount = 0;
            int avg = 0;
            Console.WriteLine($"Enter Numbers: ");
            while (true)
            {
                int num = int.Parse(Console.ReadLine());
                if (num == -1)
                {
                    break;
                }
                if (num < smallest)
                {
                    smallest = num;
                }
                if (num > largest)
                {
                    largest = num;
                }
                if (num % 2 == 0)
                {
                    evenCount++;
                }
                else
                {
                    oddCount++;
                }
                sum = sum + num;
                count++;
            }
            avg += sum / count;

            Console.WriteLine($"The count of numbers entered: {count}");
            Console.WriteLine($"The Largest Number: {largest}");
            Console.WriteLine($"The Smallest Number: {smallest}");
            Console.WriteLine($"sum: {sum}");
            Console.WriteLine($"The average of the numbers you entered is: {avg}");
            Console.WriteLine($"Count Of Odd Numbers Entered: {oddCount}");
            Console.WriteLine($"Count Of Even Numbers Entered: {evenCount}");
            Console.ReadLine();
        }

    }
}
