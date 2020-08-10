using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef11
{
    class Program
    {
        static void Main(string[] args)
        {
            int groote = 4;
            int spacies = groote-1;
            int teller = 1;

            for (int i = 1; i <= groote; i++)
            {
                for (int j = 1; j <= spacies; j++)
                {
                    Console.Write(" ");
                }
                spacies--;
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{teller} ");
                    teller++;
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}
