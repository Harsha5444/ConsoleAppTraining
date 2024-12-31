using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAtasks
{
    internal class Task19_LINQExample2
    {
        static void Main(string[] args)
        {
            Task19_LINQExample1 list = new Task19_LINQExample1();
            var employees = list.GetEmployees();
            //Query Syntax
            //var emps = from emp in employees where emp.DeptID == 10 && emp.Salary > 25000 select emp;
            // Method Syntax
            var emps = employees.Where(e => e.DeptID == 10 && e.Salary > 25000).ToList();
            Console.WriteLine("Employees are:");
            foreach (var emp in emps)
            {
                Console.WriteLine($"{emp.Id}    -   {emp.Name}  -   {emp.Salary}    -   {emp.DOJ.ToShortDateString()}   -   {emp.DeptID}");
            }
            Console.Read();
        }
    }
}
