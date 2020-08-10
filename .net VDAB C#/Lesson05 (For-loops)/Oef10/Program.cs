using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef10
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal;
            int teller = 0;
            do
            {
                Console.Write("Input: ");

            } while (!int.TryParse(Console.ReadLine(), out getal));

            for (int i = 1; i <= getal; i++)
            {
                for (int x = 1; x <= i; x++)
                {
                    teller++;
                    Console.Write($"{teller} ");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
