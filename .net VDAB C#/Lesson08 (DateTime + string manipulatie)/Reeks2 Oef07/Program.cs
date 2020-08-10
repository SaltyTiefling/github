using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Reeks2_Oef07
{
    class Program
    {
        static void Main(string[] args)
        {
            bool palindroom = false;
            do
            {
                Console.Write("geef een palindroom in: ");
                string input = Console.ReadLine();
                string output = "";
                foreach (var character in input)
                {
                    output = character + output;
                }

                if (output == input)
                {
                    palindroom = true;
                    Console.WriteLine($"goed gedaan \"{input}\" is een palidroom");
                }
                else
                {
                    Console.WriteLine($"\"{input}\" is \"{output}\" omgekeerd dus geen palidroom");
                }
            } while (!palindroom);
            Console.ReadLine();
        }
    }
}
