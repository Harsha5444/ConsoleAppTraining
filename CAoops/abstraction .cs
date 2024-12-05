using System;

namespace CAoops
{
    abstract class Vehicle
    {
        public abstract void Drive(); // Abstract method with no implementation
    }

    class Car : Vehicle
    {
        public override void Drive()
        {
            Console.WriteLine("Driving a car.");
        }
    }

    class abstraction
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Car(); // Instantiate a Car using Vehicle reference
            vehicle.Drive();             // Calls the overridden Drive() in Car
        }
    }
}
