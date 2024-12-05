using System;

namespace CAoops
{
    class Animal
    {
        public void Eat()
        {
            Console.WriteLine("This animal is eating.");
        }
    }

    class Dog : Animal // Dog inherits from Animal
    {
        public void Bark()
        {
            Console.WriteLine("The dog is barking.");
        }
    }

    class Inheritance
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog(); // Create an instance of Dog
            dog.Eat();           // Inherited from Animal
            dog.Bark();          // Unique to Dog
        }
    }
}
