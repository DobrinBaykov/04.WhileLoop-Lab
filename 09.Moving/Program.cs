using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.Moving
{
    class Program
    {
        static void Main(string[] args)
        {
            int width = int.Parse(Console.ReadLine());
            int length = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            int totalVolume = width * length * height;
            int volumeLeft = totalVolume;
            while (volumeLeft > 0)
            {
                string input = Console.ReadLine();
                if (input == "Done")
                {
                    if (volumeLeft > 0) Console.WriteLine($"{volumeLeft} Cubic meters left.");
                    break;
                }
                else
                {
                    int boxesCarried = int.Parse(input);
                    volumeLeft -= boxesCarried;
                }
            }
            if (volumeLeft < 0)
            {
                Console.WriteLine($"No more free space! You need {Math.Abs(volumeLeft)} Cubic meters more.");
            }
        }
    }
}
