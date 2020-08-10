using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Priemgetallen tot 100:");

            int lengte = 100;


            for (int number = 0; number <= lengte; number++)
            {
                if (IsPrime(number))
                {
                    Console.Write($"{number} ");
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
