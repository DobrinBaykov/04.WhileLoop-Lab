using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Walking
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSteps = 0;
            while (totalSteps < 10_000)
            {
                string input = Console.ReadLine().ToLower();

                if (input == "going home")
                {
                    int stepsToHome = int.Parse(Console.ReadLine());
                    totalSteps += stepsToHome;
                    break;
                }
                else
                {
                    int stepsCount = int.Parse(input);
                    totalSteps += stepsCount;
                }
            }
            if (totalSteps >= 10_000)
            {
                Console.WriteLine("Goal reached! Good job!");
            }
            else
            {
                int stepsToReachGoal = 10000 - totalSteps;
                Console.WriteLine($"{stepsToReachGoal} more steps to reach goal.");
            }
        }
    }
}