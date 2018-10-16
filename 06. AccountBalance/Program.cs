using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.AccountBalance
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalTransanctions = int.Parse(Console.ReadLine());
            int transactionsleft = totalTransanctions;
            double accountBalance = 0;
            while (transactionsleft > 0)
            {
                double inputMoney = double.Parse(Console.ReadLine());
                if (inputMoney < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                else
                {
                    Console.WriteLine($"Increase: {inputMoney:F2}");
                    accountBalance += inputMoney;
                    transactionsleft -= 1;
                }
            }
            Console.WriteLine($"Total: {accountBalance:F2}");
        }
    }
}
