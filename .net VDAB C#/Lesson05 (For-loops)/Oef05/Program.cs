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
            int getal;
            do
            {
                Console.Write("Input: ");

            } while (!int.TryParse(Console.ReadLine(), out getal));

            for (int i = 1; i <= getal; i++)
            {
                Console.WriteLine($"Het kwadraat van {i} is {Math.Pow(i,2)}.");
            }
            Console.ReadLine();
        }
    }
}
