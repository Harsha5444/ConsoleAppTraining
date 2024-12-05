using System;

namespace CAoops
{
    class Student
    {
        public string Name;  // Data (Property)
        public void Study()  // Behavior (Method)
        {
            Console.WriteLine($"{Name} is studying.");
        }
    }

    class Encapsulation
    {
        static void Main(string[] args)
        {
            Student student = new Student();  // Create an instance of Student
            student.Name = "Alice";           // Set the Name property
            student.Study();                  // Call the Study method
        }
    }
}
