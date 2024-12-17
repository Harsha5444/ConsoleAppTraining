using System;
using System.Collections.Generic;

namespace CAtasks
{
    class Task14_GenericCollections
    {
        static void Main(string[] args)
        {
            // 1. List<T> Example
            Console.WriteLine("1. List<T> Example:");
            List<int> list = new List<int> { 1, 2, 3 };
            list.Add(4);                 // Adds an item
            list.Remove(2);              // Removes a specific item
            list.Insert(1, 5);           // Inserts at index 1
            Console.WriteLine("List contents: " + string.Join(", ", list));
            Console.WriteLine($"List Capacity: {list.Capacity}, Count: {list.Count}");

            // 2. Dictionary<TKey, TValue> Example
            Console.WriteLine("\n2. Dictionary<TKey, TValue> Example:");
            Dictionary<string, int> dictionary = new Dictionary<string, int>
            {
                { "One", 1 },
                { "Two", 2 },
                { "Three", 3 }
            };
            dictionary.Add("Four", 4);   // Adds a new key-value pair
            dictionary.Remove("Two");   // Removes a key-value pair
            if (dictionary.TryGetValue("Three", out int value))
            {
                Console.WriteLine($"Value for 'Three': {value}");
            }
            Console.WriteLine("Dictionary contents:");
            foreach (var kvp in dictionary)
                Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");

            // 3. Queue<T> Example
            Console.WriteLine("\n3. Queue<T> Example:");
            Queue<string> queue = new Queue<string>();
            queue.Enqueue("First");     // Adds an item to the queue
            queue.Enqueue("Second");
            queue.Enqueue("Third");
            Console.WriteLine($"Dequeued item: {queue.Dequeue()}"); // Removes the oldest item
            Console.WriteLine($"Peek item: {queue.Peek()}");        // Shows the next item without removing
            Console.WriteLine("Queue contents: " + string.Join(", ", queue));

            // 4. Stack<T> Example
            Console.WriteLine("\n4. Stack<T> Example:");
            Stack<string> stack = new Stack<string>();
            stack.Push("First");        // Adds an item to the stack
            stack.Push("Second");
            stack.Push("Third");
            Console.WriteLine($"Popped item: {stack.Pop()}");       // Removes the newest item
            Console.WriteLine($"Peek item: {stack.Peek()}");        // Shows the top item without removing
            Console.WriteLine("Stack contents: " + string.Join(", ", stack));

            // 5. HashSet<T> Example
            Console.WriteLine("\n5. HashSet<T> Example:");
            HashSet<int> hashSet = new HashSet<int> { 1, 2, 3, 4 };
            hashSet.Add(5);             // Adds a unique item
            hashSet.Add(3);             // Duplicate, will not be added
            hashSet.Remove(2);          // Removes a specific item
            Console.WriteLine("HashSet contents: " + string.Join(", ", hashSet));
            Console.WriteLine($"Contains 3? {hashSet.Contains(3)}");

            // 6. LinkedList<T> Example
            Console.WriteLine("\n6. LinkedList<T> Example:");
            LinkedList<string> linkedList = new LinkedList<string>();
            linkedList.AddLast("First");   // Adds an item to the end
            linkedList.AddFirst("Zero");  // Adds an item to the beginning
            linkedList.AddLast("Second");
            linkedList.Remove("First");   // Removes a specific item
            Console.WriteLine("LinkedList contents:");
            foreach (var item in linkedList)
                Console.WriteLine(item);

            Console.ReadLine();
        }
    }
}
