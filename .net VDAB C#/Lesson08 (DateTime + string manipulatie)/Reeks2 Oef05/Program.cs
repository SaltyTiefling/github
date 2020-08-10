using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reeks2_Oef05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Woord/zin 1: ");
            string input = Console.ReadLine();
            Console.Write("Woord/zin 2: ");
            string input2 = Console.ReadLine();
            Console.WriteLine((input.Length == input2.Length) ? "deze woorden zijn even lang" : "deze woorden zijn niet even lang");
            Console.ReadLine();        
        }
    }
}
