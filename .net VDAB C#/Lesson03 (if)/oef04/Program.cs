using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Prijs fiets: ");
            double prijs = Convert.ToDouble(Console.ReadLine());

            if (prijs >= 400)
            {
                prijs -= prijs*20/100;
                Console.WriteLine($"De prijs na 20% korting: {prijs} euro");
            }
            else
            {
                Console.WriteLine("Je hebt geen recht op een korting");
            }
            Console.ReadLine();
        }
    }
}
