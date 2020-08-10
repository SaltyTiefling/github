using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reeks2_Oef12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een string in: ");
            string input = Console.ReadLine().ToLower();

            input = input.First().ToString().ToUpper() + input.Substring(1);

            Console.WriteLine(input);
            Console.ReadLine();

        }
    }
}
