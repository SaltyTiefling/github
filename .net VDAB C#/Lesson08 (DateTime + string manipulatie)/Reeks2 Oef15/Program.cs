using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reeks2_Oef15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("geef string in: ");
            string input = Console.ReadLine();

            Console.Write("geef controle in: ");
            string controle = Console.ReadLine();

            Console.WriteLine(input.IndexOf(controle));
            Console.ReadLine();
        }
    }
}
