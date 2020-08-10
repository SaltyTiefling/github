using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Letter: ");
            char letter = Convert.ToChar(Console.ReadLine().ToLower()) ;
            switch (letter)
            {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("Dat is een klinker");
                    break;
                default:
                    Console.WriteLine("Dat is een medeklinker");
                    break;
            }
            Console.ReadLine();
        }
    }
}
