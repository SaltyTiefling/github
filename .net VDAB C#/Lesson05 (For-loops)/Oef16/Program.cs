using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Oef16
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengte = 0;
            List<int> priemnumbers = new List<int>();

            do
            {
                Console.Write("Input: ");
            } while (!int.TryParse(Console.ReadLine(), out lengte));


            for (int number = 0; number <= lengte; number++)
            {
                if (IsPrime(number))
                {
                    priemnumbers.Add(number);
                }
            }

            for (int getal1 = 0; getal1 < priemnumbers.Count; getal1++)
            {
                for (int getal2 = getal1; getal2 < priemnumbers.Count; getal2++)
                {
                    if ( priemnumbers[getal1] + priemnumbers[getal2] ==  lengte)
                    {
                        Console.WriteLine($"{priemnumbers[getal1]} + {priemnumbers[getal2]} = {lengte}");
                    }
                }

            }

            Console.ReadLine();

        }
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            var boundary = (int)Math.Floor(Math.Sqrt(number));

            for (int i = 3; i <= boundary; i += 2)
                if (number % i == 0)
                    return false;

            return true;
        }
    }
}
