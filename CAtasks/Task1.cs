using System;

namespace CAtasks
{
    class Task1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your firstName: ");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter Your lastName: ");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter Your Designation: ");
            string designation = Console.ReadLine();

            Console.WriteLine("Enter Your Salary: ");
            int salary = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Your Increment: ");
            int increment = int.Parse(Console.ReadLine());

            //int FinalSalary = salary + (salary / increment);
            //can also use an intermediate variable 

            Console.WriteLine("Welcome " + firstName + " " + lastName);
            Console.WriteLine("your Total Salary is: " + (salary + (salary * increment) / 100));
            Console.ReadLine();
        }
    }
}
