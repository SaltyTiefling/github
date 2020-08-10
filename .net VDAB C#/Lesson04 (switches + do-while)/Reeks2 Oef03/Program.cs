using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reeks2_Oef04
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal;
            do
            {
                Console.Write("Input:");
            } while (!int.TryParse(Console.ReadLine(), out getal));

            while (getal <20)
            {
                getal += 5;
                Console.WriteLine(getal);
                getal -= 3;
                Console.WriteLine(getal);
            }
            Console.ReadLine();

        }
    }
}
