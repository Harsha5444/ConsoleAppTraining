using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CACode
{
    class GradeCalculator
    {
        // Create methods to:
        // 1. Calculate final grade (tests are 40%, assignments 60%)
        // 2. Determine letter grade (A: 90+, B: 80-89, C: 70-79, D: 60-69, F: below 60)
        // 3. Check if student passed (grade >= 60)
        public double CalculateFinalGrade(double[] tests, double[] assignments)
        {
            double avgtests = calculateaverage(tests);
            double avgassignments = calculateaverage(assignments);
            double finalgrade =  (avgtests*0.4 + avgassignments*0.6);
            return finalgrade;
        }

        public double calculateaverage(double[] scores)
        {            
            double sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }
            return sum / scores.Length;           
        }

        public string lettergrade(double finalgrade)
        {
            if (finalgrade >= 90) return "A";
            else if (finalgrade >= 80) return "B";
            else if (finalgrade >= 70) return "C";
            else if (finalgrade >= 60) return "D";
            else return "F";
        }

        public bool IsStudentPassed(double finalGrade)
        {
            return finalGrade >= 60;
        }

    }

    class program
    {
        static void Main(string[] args)
        {
            GradeCalculator calculator = new GradeCalculator();
            double[] tests = { 45, 30, 28 };  
            double[] assignments = { 12, 38, 24 };

            double finalgrade = calculator.CalculateFinalGrade(tests ,assignments);
            string lettergrade = calculator.lettergrade(finalgrade);
            bool passed = calculator.IsStudentPassed(finalgrade);

            Console.WriteLine($"Final Grade: {finalgrade:F2}");
            Console.WriteLine($"Letter Grade: {lettergrade}");
            Console.WriteLine($"Passed: {(passed ? "Yes" : "No")}");
        }
    }
}
