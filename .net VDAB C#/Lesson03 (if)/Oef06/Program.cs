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
            int teller = 0;
            Console.Write("Heb je moeten lachen vandaag (Y/N)?: ");
            if (Console.ReadLine().ToUpper() == "Y")
            {
                teller++;
            }
            Console.Write("Ben je productief geweest? (Y/N): ");
            if (Console.ReadLine().ToUpper() == "Y")
            {
                teller++;
            }
            Console.Write("Sheen de zon vandaag? (Y/N): ");
            if (Console.ReadLine().ToUpper() == "Y")
            {
                teller++;
            }
            Console.Write("heb je iets lekkers gegeten vandaag? (Y/N): ");
            if (Console.ReadLine().ToUpper() == "Y")
            {
                teller++;
            }
            Console.Write("kijk je uit naar morgen? (Y/N): ");
            if (Console.ReadLine().ToUpper() == "Y")
            {

                teller++;
            }
            if (teller >= 3)
            {
                Console.WriteLine("Super!");
            }
            else
            {
                Console.WriteLine("Jammer, kan gebeuren. :(");
            }
            Console.ReadLine();
        }
    }
}
