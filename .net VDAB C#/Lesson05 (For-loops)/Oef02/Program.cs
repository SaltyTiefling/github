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
            int getal;
            do
            {
                Console.Write("Input: ");

            } while (!int.TryParse(Console.ReadLine(), out getal));

            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"{getal*i} ");
            }
            Console.ReadLine();


        }
    }
}
