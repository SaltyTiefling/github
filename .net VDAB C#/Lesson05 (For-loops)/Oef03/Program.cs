using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef03
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal;
            int som = 0;

            do
            {
                Console.Write("Input: ");
            } while (!int.TryParse(Console.ReadLine(), out getal));

            for (int i = 1; i <= getal; i++)
            {
                Console.Write($"{i} ");
                som += i;
            }
            Console.WriteLine();
            Console.WriteLine($"som: {som}");
            Console.ReadLine();
        }
    }
}
