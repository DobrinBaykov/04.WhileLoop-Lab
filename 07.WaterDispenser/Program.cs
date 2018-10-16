using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.WaterDispenser
{
    class Program
    {
        static void Main(string[] args)
        {
            double glassVolume = double.Parse(Console.ReadLine());
            double waterFilled = 0;
            int timesTapped = 0;

            while (waterFilled < glassVolume)
            {
                string tappedButton = Console.ReadLine();
                timesTapped += 1;
                if (tappedButton == "Easy") waterFilled += 50;
                else if (tappedButton == "Medium") waterFilled += 100;
                else if (tappedButton == "Hard") waterFilled += 200;
            }
            if (waterFilled == glassVolume)
            {
                Console.WriteLine($"The dispenser has been tapped {timesTapped} times.");
            }
            else if (waterFilled > glassVolume)
            {
                double waterSpilled = waterFilled - glassVolume;
                Console.WriteLine($"{waterSpilled}ml has been spilled.");
            }
        }
    }
}
