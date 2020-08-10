using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Geef een letter in: ");
            char letter = Convert.ToChar(Console.ReadLine());
            int letterAsInt = Convert.ToInt32(letter);
            Console.WriteLine($"Na {letter} komt {Convert.ToChar(letterAsInt + 1)}.");
            Console.ReadLine();
        }
    }
}
