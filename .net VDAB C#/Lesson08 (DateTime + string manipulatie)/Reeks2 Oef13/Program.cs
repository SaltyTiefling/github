using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reeks2_Oef13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een string in: ");
            string input = Console.ReadLine();
            string output = "";

            foreach (var character in input)
            {
                if (character.ToString() == character.ToString().ToLower())
                {
                    output += character.ToString().ToUpper();
                }
                else if (character.ToString() == character.ToString().ToUpper())
                {
                    output += character.ToString().ToLower();
                }
                else
                {
                    output += character;
                }
            }
            Console.WriteLine(output);
            Console.ReadLine();
        }
    }
}
