using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Getal 1: ");
            double getal1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Getal 2: ");
            double getal2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Getal 3: ");
            double getal3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            Console.WriteLine($"{getal1} - {getal2} - {getal3}");
            Console.WriteLine($"{getal1} - {getal3} - {getal2}");
            Console.WriteLine($"{getal2} - {getal1} - {getal3}");
            Console.WriteLine($"{getal2} - {getal3} - {getal1}");
            Console.WriteLine($"{getal3} - {getal2} - {getal1}");
            Console.WriteLine($"{getal3} - {getal1} - {getal2}");
            Console.ReadLine();
        }
    }
}
