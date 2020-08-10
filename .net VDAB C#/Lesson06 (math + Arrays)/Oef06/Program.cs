using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef06
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

            Console.WriteLine($"Vierkantswortel: {Math.Sqrt(getal1)}");
            Console.WriteLine($"Kwadraat: {Math.Pow(getal1,2)}");
            Console.ReadLine();

        }
    }
}
