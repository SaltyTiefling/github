using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reeks2_Oef03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geef je string in:");
            string input = Console.ReadLine();
            string output = "";
            
            foreach (var character in input)
            {
                output = Convert.ToString(character) + output;
            }
            Console.WriteLine(output);
            Console.ReadLine();

        }
    }
}
