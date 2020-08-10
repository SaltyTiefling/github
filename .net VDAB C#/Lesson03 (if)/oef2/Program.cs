using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Getal1: ");
            double getal1 = Convert.ToDouble(Console.ReadLine());

            if (getal1 >= 5)
            {
                Console.WriteLine("Gestaagd!");
            }
            else
            {
                Console.WriteLine("Gebuisd...");
            }
            Console.ReadLine();
        }
    }
}
