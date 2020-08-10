using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef01
{
    class Program
    {
        static void Main(string[] args)
        {
            double getal = new Random().Next(1,11);
            Console.WriteLine($"Willekeurig getal van 1 ot en met 10: {getal}");
            Console.ReadLine();
        }
    }
}
