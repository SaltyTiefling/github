using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef03
{
    class Program
    {
        static void Main(string[] args)
        {
            double getal1;
            do
            {
                Console.Write("Getal 1: ");
            } while (!double.TryParse(Console.ReadLine(), out getal1));

            double getal2;
            do
            {
                Console.Write("Getal 2: ");
            } while (!double.TryParse(Console.ReadLine(), out getal2));

            double getal = new Random().NextDouble() *(Math.Max(getal2, getal1) - Math.Min(getal2, getal1)) + Math.Min(getal2, getal1);
            Console.Write($"Willekeurig getal van {Math.Min(getal2, getal1)} tot en met {Math.Max(getal2, getal1)}: {Math.Round(getal, 2)}");
            Console.ReadLine();
        }
    }
}
