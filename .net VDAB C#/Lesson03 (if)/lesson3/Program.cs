using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Getal1: ");
            double getal1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Getal2: ");
            double getal2 = Convert.ToDouble(Console.ReadLine());

            if (getal1 > getal2)
            {
                Console.WriteLine($"het grootste getal is {getal1}");
            }
            else {
                Console.WriteLine($"het grootste getal is {getal2}");
            }
            Console.ReadLine();
        }
    }
}
