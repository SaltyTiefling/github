using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef04
{
    class Program
    {
        static void Main(string[] args)
        {
            int Aantal;
            int som= 0;

            do
            {
                Console.Write("Aantal: ");
            } while (!int.TryParse(Console.ReadLine(), out Aantal));

            for (int i = 1; i <= Aantal; i++)
            {
                int input;
                do
                {
                    Console.Write($"Getal {i}: ");
                } while (!int.TryParse(Console.ReadLine(), out input));
                som +=input;
            }
            double average = som / Aantal;
            Console.WriteLine($"Gemiddelde: {Math.Round(average, 2)}");
            Console.ReadLine();
        }
    }
}
