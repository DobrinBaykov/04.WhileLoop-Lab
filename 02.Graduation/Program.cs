using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            string studentName = Console.ReadLine();
            int counter = 1;
            double sumOfGrades = 0;

            while (counter <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4.00)
                {
                    counter++;
                    sumOfGrades = sumOfGrades + grade;
                }
            }
            double averageGrade = sumOfGrades / 12;
            Console.WriteLine($"{studentName} graduated. Average grade: {averageGrade:F2}");
        }
    }
}
