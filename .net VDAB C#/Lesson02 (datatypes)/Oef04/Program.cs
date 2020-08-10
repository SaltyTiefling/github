using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Voornaam: ");
            string Voornaam = Console.ReadLine();

            Console.Write("Achternaam: ");
            string achternaam = Console.ReadLine();

            Console.Write("Adres: ");
            string adres = Console.ReadLine();

            Console.Write("Postcode: ");
            string postcode = Console.ReadLine();

            Console.Write("Hobby's: ");
            string hobby = Console.ReadLine();

            Console.WriteLine($"Dag {Voornaam} {achternaam}! Jij woont op {adres}, {postcode}.{Environment.NewLine}Jouw hobby's zijn {hobby}");
            Console.ReadLine();
        }
    }
}
