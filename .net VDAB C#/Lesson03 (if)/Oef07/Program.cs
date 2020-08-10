using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Getal1: ");
            double getal1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Getal2: ");
            double getal2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Getal3: ");
            double getal3 = Convert.ToDouble(Console.ReadLine());

            if (getal1 < getal2 && getal1 < getal3)
            {
                Console.Write($"{getal1} - ");
                if (getal2 < getal3)
                {
                    Console.WriteLine($"{getal2} - {getal3}");
                }
                else
                {
                    Console.WriteLine($"{getal3} - {getal2}");
                }
            }
            else if (getal2 < getal3 && getal2 < getal1)
            {
                Console.Write($"{getal2} - ");
                if (getal1 < getal3)
                {
                    Console.WriteLine($"{getal1} - {getal3}");
                }
                else
                {
                    Console.WriteLine($"{getal3} - {getal1}");
                }

            }
            else if (getal3 < getal2 && getal3 < getal1)
            {
                Console.Write($"{getal3} - ");
                if (getal2 < getal1)
                {
                    Console.WriteLine($"{getal2} - {getal1}");
                }
                else
                {
                    Console.WriteLine($"{getal1} - {getal2}");
                }
            }
            Console.ReadLine();
        }
    }
}
