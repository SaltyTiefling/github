using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef08
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Getal 1: ");
            double getal1 = Convert.ToDouble(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine($"{getal1} X {i} = {getal1 * i}");
            }
            Console.ReadLine();
        }
    }
}
