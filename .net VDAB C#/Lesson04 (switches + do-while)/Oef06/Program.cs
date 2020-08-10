using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef06
{
    class Program
    {
        static void Main(string[] args)
        {
            int jaar = DateTime.Now.Year;
            do
            {
                Console.Write("Jaartal: ");
                jaar = Convert.ToInt32(Console.ReadLine());
                if (((jaar % 4 == 0) && (jaar % 100 != 0)) || (jaar % 400 == 0))
                {
                    Console.WriteLine($"{jaar} is a Leap Year.");
                }
                else
                {
                    Console.WriteLine($"{jaar} is not a Leap Year.");
                };
            } while (jaar != 0);
                Console.ReadLine();

        }
    }
}
