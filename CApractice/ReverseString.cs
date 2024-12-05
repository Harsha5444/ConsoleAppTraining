using System;

namespace CApractice
{
    internal class ReverseString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to reverse: ");
            char[] name = Console.ReadLine().ToCharArray(); // Convert string to char array for swapping
            int start = 0; // Pointer at the beginning
            int end = name.Length - 1; // Pointer at the end

            // Swap characters until the pointers meet in the middle
            while (start < end)
            {
                char temp = name[start];
                name[start] = name[end];
                name[end] = temp;

                start++; // Move start pointer forward
                end--;   // Move end pointer backward
            }

            Console.WriteLine($"Reversed String: {new string(name)}");
            Console.Read();
        }
    }
}
