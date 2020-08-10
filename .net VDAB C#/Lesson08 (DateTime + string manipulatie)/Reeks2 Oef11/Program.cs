using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reeks2_Oef11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een string in: ");
            string input = Console.ReadLine();
            Console.Write("waar wil je op testen: ");
            string controle = Console.ReadLine();

            Console.WriteLine((input.Contains(controle))? $"{controle} zit in {input}" : $"{controle} zit niet in {input}");
            Console.ReadLine();

        }
    }
}
