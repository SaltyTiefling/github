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
            Console.Write("Getal 1: ");
            double getal1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Getal 2: ");
            double getal2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Als je {getal1} deelt door {getal2}, dan is de rest {getal1%getal2}.");
            Console.ReadLine();
        }
    }
}
