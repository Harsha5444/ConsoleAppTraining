using System;

namespace CApractice
{
    //Class
    class Employee
    {
        int empId; string empName; double salary;
        string city; string state;string role; string depot;int id;

        public Employee(int empId, string empName, double salary , Employee loc)
        {
            this.empId = empId;
            this.empName = empName;
            this.salary = salary;
            this.city = loc.city;
            this.state = loc.state;
        }

        public Employee (String city , String state)
        {
            this.city = city;   
            this.state = state;
        }
        public void Display()
        {
            Console.WriteLine($"EmpID: {empId}, EmpName: {empName} and Salary: {salary}");
            Console.WriteLine($"City: {city} and State: {state}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee loc = new Employee("HYD","Ts");

            Employee emp1 = new Employee(10,"harsha",1089365.00,loc);
            emp1.Display();

            Employee emp2 = new Employee(12, "haredfawefsha", 10543.00, loc);
            emp2.Display();


            Console.Read();
        }
    }
}
