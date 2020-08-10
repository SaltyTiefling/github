using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reeks2_Oef02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef je string in:");
            string input = Console.ReadLine();
            foreach (var character in input)
            {
                Console.Write($"{character} ");
            }
            Console.ReadLine();
        }
    }
}
