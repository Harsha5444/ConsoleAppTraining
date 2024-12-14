using System;

namespace CAtasks
{
    // Base class
    class Vehicle
    {
        // Method Overloading: Multiple methods with the same name but different parameters
        public void Start()
        {
            Console.WriteLine("Vehicle is starting...");
        }

        public void Start(string keyType)
        {
            Console.WriteLine($"Vehicle is starting with a {keyType} key...");
        }

        // Virtual method for Overriding
        public virtual void Drive()
        {
            Console.WriteLine("Vehicle is driving...");
        }

        // Method Hiding: A non-virtual method
        public void Stop()
        {
            Console.WriteLine("Vehicle has stopped.");
        }
    }

    // Derived class
    class Car : Vehicle
    {
        // Overriding: Changing the behavior of a virtual method
        public override void Drive()
        {
            Console.WriteLine("Car is driving smoothly...");
        }

        // Method Hiding: Hides the base class method
        public new void Stop()
        {
            Console.WriteLine("Car has stopped safely.");
        }
    }

    // Program to demonstrate the concepts
    class Task11
    {
        static void Main(string[] args)
        {
            // Method Overloading
            Vehicle vehicle = new Vehicle();
            vehicle.Start();
            vehicle.Start("smart");

            Console.WriteLine();

            // Method Overriding
            Vehicle carAsVehicle = new Car();
            carAsVehicle.Drive(); // Calls the overridden method in the Car class

            Console.WriteLine();

            // Method Hiding
            Vehicle baseVehicle = new Vehicle();
            baseVehicle.Stop(); // Calls the base class method

            Car derivedCar = new Car();
            derivedCar.Stop(); // Calls the hidden method in the Car class
        }
    }
}
