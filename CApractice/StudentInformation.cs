using System;

namespace CAPractice
{
    class StudentInformation
    {
        static void Main()
        {
            string fullName = "Harsha";

            // int might be more appropriate than short for age
            int age = 24;

            // Using decimal might be more appropriate for academic scores
            decimal gpa = 94.36m;

            bool enrollmentStatus = true;

            // Using string interpolation for cleaner code
            Console.WriteLine($"The student Name is {fullName}. His Age is {age}. His GPA is {gpa}.");
            Console.WriteLine($"Is He Enrolled? {enrollmentStatus}");

            Console.ReadLine();
            Console.ReadLine();
        }

    }
}
