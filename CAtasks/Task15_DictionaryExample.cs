using System;
using System.Collections.Generic;

namespace CAtasks
{
    class Task15_DictionaryExample
    {
        static void Main(string[] args)
        {
            // Create a Dictionary
            Dictionary<int, string> dictionary = new Dictionary<int, string>();

            // 1. Add key-value pairs
            dictionary.Add(1, "Apple");
            dictionary.Add(2, "Banana");
            dictionary.Add(3, "Cherry");

            Console.WriteLine("Dictionary after adding items:");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // 2. TryGetValue
            if (dictionary.TryGetValue(2, out string value))
            {
                Console.WriteLine($"\nValue for key 2: {value}");
            }
            else
            {
                Console.WriteLine("\nKey not found!");
            }

            // 3. ContainsKey
            Console.WriteLine("\nDoes key 4 exist? " + dictionary.ContainsKey(4));

            // 4. ContainsValue
            Console.WriteLine("Does value 'Apple' exist? " + dictionary.ContainsValue("Apple"));

            // 5. Remove a key-value pair
            dictionary.Remove(2);
            Console.WriteLine("\nDictionary after removing key 2:");
            foreach (var kvp in dictionary)
            {
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
            }

            // 6. Access Keys and Values
            Console.WriteLine("\nAll Keys:");
            foreach (int key in dictionary.Keys)
            {
                Console.WriteLine(key);
            }

            Console.WriteLine("\nAll Values:");
            foreach (string val in dictionary.Values)
            {
                Console.WriteLine(val);
            }

            // 7. Count Property
            Console.WriteLine($"\nTotal key-value pairs in dictionary: {dictionary.Count}");

            Console.ReadLine();
        }
    }
}
