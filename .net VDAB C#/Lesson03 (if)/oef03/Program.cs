using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Getal: ");
            double getal = Convert.ToDouble(Console.ReadLine());
            if (getal < 0 || getal > 9)
            {
                Console.WriteLine("Foutmelding");
            }
            else {
                if (getal % 2 == 0)
                {
                    Console.WriteLine("Dat is een even getal");
                }
                else {
                    Console.WriteLine("dat is een oneven getal");
                }
                            
            }
            Console.ReadLine();
        }
    }
}
