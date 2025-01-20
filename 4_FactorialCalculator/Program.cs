using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_FactorialCalculator
{
    internal class Program
    {
        static void Main()
        {
            Console.Write("Enter a number: ");
            string input = Console.ReadLine();
            int num;

            if (int.TryParse(input, out num) && num >= 0)
            {
                long factorial = 1;
                for ( int i = 1; i <= num; i++ )
                {
                    factorial *= i;
                }
                Console.WriteLine($"The factorial of {num} is {factorial}.");
            }
            else
            {
                Console.WriteLine("Invalid! Enter a non-negative integer.");
            }
            Console.ReadLine();
        }
    }
}
