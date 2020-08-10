using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef13
{
    class Program
    {
        static void Main(string[] args)
        {
            int fac;

            do
            {
                Console.Write("Input: ");
            } while (!int.TryParse(Console.ReadLine(), out fac));


            for (int i = 1; i < fac; i++)
            {
                fac *= i;
            }
            Console.WriteLine($"faculteit: {fac}");
            Console.ReadLine();
        }
    }
}
