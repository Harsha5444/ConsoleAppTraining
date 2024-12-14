using System;

namespace CAtasks
{
    // Base class
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void ShowDetails()
        {
            Console.WriteLine($"Name: {Name}, Age: {Age}");
        }
    }

    // Interface 1
    interface IEmployee
    {
        void Work();
    }

    // Interface 2
    interface IManager
    {
        void Manage();
    }

    // Derived class (inherits from Person and implements two interfaces)
    class Manager : Person, IEmployee, IManager
    {
        public void Work()
        {
            Console.WriteLine($"{Name} is working on a project.");
        }

        public void Manage()
        {
            Console.WriteLine($"{Name} is managing the team.");
        }
    }

    // Program
    class Task12_HybridInheritance
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager
            {
                Name = "Alice",
                Age = 35
            };

            // Base class method
            manager.ShowDetails();

            // Interface methods
            manager.Work();
            manager.Manage();
        }
    }
}
