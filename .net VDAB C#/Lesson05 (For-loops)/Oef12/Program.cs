using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef12
{
    class Program
    {
        static void Main(string[] args)
        {
            int groote;

            do
            {
                Console.Write("Input: ");
            } while (!int.TryParse(Console.ReadLine(), out groote));

            int spacies = groote-1;
            int teller = 1;

            for (int i = 1; i <= groote; i++)
            {
                for (int j = 1; j <= spacies; j++)
                {
                    Console.Write(" ");
                }
                spacies--;
                for (int j = 1; j <= teller; j++)
                {
                    Console.Write($"* ");
                }
                teller++;
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
