using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef04
{
    class Program
    {
        static void Main(string[] args)
        {
            double getal1;
            do
            {
                Console.Write("Getal: ");
            } while (!double.TryParse(Console.ReadLine(), out getal1));

            double getal2;
            do
            {
                Console.Write("Getal 2: ");
            } while (!double.TryParse(Console.ReadLine(), out getal2));

            Console.WriteLine($"Het grootste getal is {Math.Max(getal1,getal2)}.");
            Console.ReadLine();
        }
    }
}
