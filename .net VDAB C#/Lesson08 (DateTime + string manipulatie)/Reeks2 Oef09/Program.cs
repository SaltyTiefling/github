using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Reeks2_Oef09
{
    class Program
    {
        static void Main(string[] args)
        { 
            Console.Write("geef een zin in: ");
            string input = Console.ReadLine();
            List<char> inputLijst = new List<char>();

            foreach (var character in input)
            {
                inputLijst.Add(character);
            }
            inputLijst.Sort();
            foreach (var character in inputLijst)
            {
                Console.Write(character.ToString());
            }
            Console.ReadLine();
        }
    }
}
