using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef02
{
    class Program
    {
        static void Main(string[] args)
        {
            double getal = (new Random().NextDouble() * 9) +1;
            Console.WriteLine($"Willekeurig getal van 1 tot en met 10: {Math.Round(getal,2)}");
            Console.ReadLine();
        }
    }
}
