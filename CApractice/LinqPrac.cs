using System;
using System.Collections.Generic;
using System.Linq;

namespace CApractice
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Position { get; set; }
        public int DepartmentId { get; set; }
    }
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    public class Project
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int EmployeeId { get; set; }
    }
    class LinqPrac
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice", Age = 30, Position = "Developer", DepartmentId = 1 },
                new Employee { Id = 2, Name = "Bob", Age = 25, Position = "Designer", DepartmentId = 1 },
                new Employee { Id = 3, Name = "Charlie", Age = 35, Position = "Manager", DepartmentId = 2 },
                new Employee { Id = 4, Name = "David", Age = 40, Position = "CEO", DepartmentId = 3 },
                new Employee { Id = 5, Name = "Eve", Age = 29, Position = "Tester", DepartmentId = 1 }
            };
            var departments = new List<Department>
            {
                new Department { Id = 1, Name = "IT" },
                new Department { Id = 2, Name = "HR" },
                new Department { Id = 3, Name = "Finance" }
            };
            var projects = new List<Project>
            {
                new Project { Id = 1, Name = "Project A", EmployeeId = 1 },
                new Project { Id = 2, Name = "Project B", EmployeeId = 2 },
                new Project { Id = 3, Name = "Project C", EmployeeId = 3 },
                new Project { Id = 4, Name = "Project D", EmployeeId = 4 },
                new Project { Id = 5, Name = "Project E", EmployeeId = 5 }
            };
            // Example LINQ queries
            // Uncomment one by one to practice

            // Query syntax example: Get all employees over 30 years old
            //var employeesOver30 = from e in employees
            //                      where e.Age > 30
            //                      //select e.Id;
            //                      select new { e.Id, e.Name ,e.Age};
            //Console.WriteLine("Employees over 30:");
            //foreach (var employee in employeesOver30)
            //{
            //    //Console.WriteLine($"Name: {employee.Name}, Age: {employee.Age}");
            //    Console.WriteLine($"{employee}");
            //}


            // Method syntax example: Get all employees over 30 years old
            //var employeesOver30Method = employees.Where(e => e.Age > 30);
            //Console.WriteLine("Employees over 30 (Method Syntax):");
            //foreach (var employee in employeesOver30Method)
            //{
            //    Console.WriteLine($"ID: {employee.Id}, Name: {employee.Name}, Age: {employee.Age}");
            //}


            // Query syntax example: Join employees with departments
            //var employeeDepartments = from e in employees
            //                          join d in departments on e.DepartmentId equals d.Id
            //                          select new { e.Name, DeptName = d.Name };
            //Console.WriteLine("Employees with their departments:");
            //foreach (var ed in employeeDepartments)
            //{
            //    Console.WriteLine($"Name: {ed.Name}, Department: {ed.DeptName}");
            //}


            // Method syntax example: Join employees with departments
            //var employeeDepartmentsMethod = employees.Join(departments,
            //                                               e => e.DepartmentId,
            //                                               d => d.Id,
            //                                               (e, d) => new { e.Name, Department = d.Name }).ToList();
            //Console.WriteLine("Employees with their departments (Method Syntax):");
            //foreach (var ed in employeeDepartmentsMethod)
            //{
            //    Console.WriteLine($"Name: {ed.Name}, Department: {ed.Department}");
            //}

            //var outerSequence = employees;
            //var innerSequence = departments;
            //var outerKeySelector = employees.Select(e => e.DepartmentId);
            //var innerKeySelector = departments.Select(d => d.Id);
            //var joinResult = outerSequence.Join(innerSequence, e => e.DepartmentId, d => d.Id, (e, d) => new { e.Name, Department = d.Name });

            //var joinResult = employees.Join(departments,
            //                    e =>
            //                    {
            //                        Console.WriteLine($"Outer key: {e.DepartmentId}");
            //                        return e.DepartmentId;
            //                    },
            //                    d =>
            //                    {
            //                        Console.WriteLine($"Inner key: {d.Id}");
            //                        return d.Id;
            //                    },
            //                    (e, d) =>
            //                    {
            //                        Console.WriteLine($"Joining {e.Name} with {d.Name}");
            //                        return new { e.Name, Department = d.Name };
            //                    }).ToList();


            // Query syntax example: Group employees by department            
            var groupedByDepartment = from e in employees
                                      group e by e.DepartmentId into g
                                      select new { DepartmentId = g.Key, Employees = g };
            Console.WriteLine("Employees grouped by department:");
            foreach (var group in groupedByDepartment)
            {
                Console.WriteLine($"Department Id: {group.DepartmentId}");
                foreach (var employee in group.Employees)
                {
                    Console.WriteLine($"    Name: {employee.Name}, Position: {employee.Position}");
                }
            }
            

            // Method syntax example: Group employees by department
            /*
            var groupedByDepartmentMethod = employees.GroupBy(e => e.DepartmentId)
                                                     .Select(g => new { DepartmentId = g.Key, Employees = g });

            Console.WriteLine("Employees grouped by department (Method Syntax):");
            foreach (var group in groupedByDepartmentMethod)
            {
                Console.WriteLine($"Department Id: {group.DepartmentId}");
                foreach (var employee in group.Employees)
                {
                    Console.WriteLine($"    Name: {employee.Name}, Position: {employee.Position}");
                }
            }
            */

            // Add more examples as needed, such as aggregation, ordering, etc.

            Console.ReadLine(); // Keep console open
        }
    }
}
