using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reeks2_Oef01
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal;
            do
            {
            Console.Write("Getal:");
            } while (!int.TryParse(Console.ReadLine(), out getal));


            while (getal < 20)
            {
                getal++;
                Console.WriteLine(getal);
            }
            Console.ReadLine();
        }
    }
}
