using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reeks2_oef02
{
    class Program
    {
        static void Main(string[] args)
        {
            int teller = 0;
            int getal;
            do
            {
                Console.Write("Getal:");
            } while (!int.TryParse(Console.ReadLine(), out getal));

            while (teller < 5)
            {
                getal++;
                Console.WriteLine(getal);
                teller++;
            }
            Console.ReadLine();
        }
    }
}
