using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reeks2_Oef04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef je string in:");
            string input = Console.ReadLine();
            Console.WriteLine($"Deze zin bevat {input.Split(' ').Length} woorden");
            Console.ReadLine();
        }
    }
}
