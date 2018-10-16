using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.GraduationPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int schoolYear = 1;
            double sumOfGrades = 0;
            int failed = 0;

            while (schoolYear <= 12 && failed <= 1)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4.00)
                {
                    schoolYear++;
                    sumOfGrades = sumOfGrades + grade;
                }
                else failed += 1;

                // if (failed > 1) break;
            }
            if (failed <= 1)
            {
                double averageGrade = sumOfGrades / 12;
                Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:F2}");
            }
            else
            {
                Console.WriteLine($"{studentName} has been excluded at {schoolYear} grade");
            }
        }
    }
}
