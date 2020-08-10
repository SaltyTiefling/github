using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef05
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
            double getal2 = -Math.Abs(getal1);
            Console.WriteLine($"dat is negatief {getal2}.");
            Console.ReadLine();
        }
    }
}
