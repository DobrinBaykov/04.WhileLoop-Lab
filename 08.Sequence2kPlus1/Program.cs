using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Sequence2kPlus1
{
    class Program
    {
        static void Main(string[] args)
        {
            int boundaryNumber = int.Parse(Console.ReadLine());
            int currentNumber = 1;
            while (currentNumber <= boundaryNumber)
            {
                Console.WriteLine(currentNumber);
                currentNumber = 2 * currentNumber + 1;
            }
        }
    }
}
