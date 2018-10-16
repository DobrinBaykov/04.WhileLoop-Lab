using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.NumberSequence
{
    class Program
    {
        static void Main(string[] args)
        {
            int smallest = int.MaxValue;
            int biggest = int.MinValue;

            while (true)
            {
                string input = Console.ReadLine().ToLower();

                if (input == "end") break;
                else
                {
                    int number = int.Parse(input);
                    if (number < smallest) smallest = number;
                    if (number > biggest) biggest = number;
                }
            }
            Console.WriteLine($"Max number: {biggest}");
            Console.WriteLine($"Min number: {smallest}");
        }
    }
}
