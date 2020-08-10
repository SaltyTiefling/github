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
            Console.Write("Prijs drankje: ");
            double drankPrijs = Convert.ToDouble(Console.ReadLine());

            Console.Write("Aantal: ");
            double aantal = Convert.ToDouble(Console.ReadLine());

            double prijs = drankPrijs * aantal;
            Console.WriteLine($"Prijs zonder btw: {prijs} euro");

            prijs += (prijs/100)*21;
            Console.WriteLine($"Prijs met 21%: {Math.Round(prijs,2)} euro");

            Console.ReadLine();
        }
    }
}
