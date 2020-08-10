using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reeks2Oef02
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1 = 0;
            do
            {
                Console.Write("Aantal getallen om in te voeren: ");
            } while (!int.TryParse(Console.ReadLine(), out getal1));

            int[] getallenreeks = new int[getal1];
            for (int i = 0; i < getallenreeks.Length; i++)
            {
                do
                {
                    Console.Write($"getal {i+1}: ");
                } while (!int.TryParse(Console.ReadLine(), out getallenreeks[i]));
            }
            Console.Write("Deze getallen zijn");
            foreach (var item in getallenreeks)
            {
                Console.Write($" {item}");
            }
            Console.ReadLine();



        }
    }
}
