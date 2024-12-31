using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAtasks
{
        internal class Employee
        {
            public int Id { get; set; }
            public string Name { get; set; }
            public double Salary { get; set; }
            public DateTime DOJ { get; set; }
            public int DeptID { get; set; }
        }
        class Task19_LINQExample1
        {
            public List<Employee> GetEmployees()
            {
                List<Employee> employees = new List<Employee>()
            {
                new Employee(){Id = 1,Name = "Srikanth",Salary=20000,DOJ = new DateTime(2013,01,04),DeptID=10},
                new Employee(){Id = 2,Name = "Raju",Salary=26000,DOJ = new DateTime(2015,01,04),DeptID=10},
                new Employee(){Id = 3,Name = "Ramesh",Salary=18000,DOJ = new DateTime(2013,01,04),DeptID=20},
                new Employee(){Id = 4,Name = "Suresh",Salary=31000,DOJ = new DateTime(2014,01,04),DeptID=30},
                new Employee(){Id = 5,Name = "Rajesh",Salary=16000,DOJ = new DateTime(2017,01,04),DeptID=10},
                new Employee(){Id = 6,Name = "Phani",Salary=32000,DOJ = new DateTime(2015,01,04),DeptID=20},
                new Employee(){Id = 7,Name = "Vasu",Salary=12000,DOJ = new DateTime(2018,01,04),DeptID=30}
            };
                return employees;
            }
            static void Main(string[] args)
            {
                Task19_LINQExample1 list = new Task19_LINQExample1();
                var employees = list.GetEmployees();
            //Query Syntax
            //var emps = from emp in employees where emp.DOJ.Year == 2013 select emp;
            //Method Syntax
            var emps = employees.Where(e => e.DOJ.Year ==2013).ToList();
                foreach (var emp in emps)
                {
                    Console.WriteLine($"{emp.Id}    -   {emp.Name}  -   {emp.Salary}    -   {emp.DOJ}   -   {emp.DeptID}");
                }
                Console.Read();
            }
        }
}
