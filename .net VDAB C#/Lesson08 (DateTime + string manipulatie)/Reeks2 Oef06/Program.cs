using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reeks2_Oef06
{
    class Program
    {
        static void Main(string[] args)
        {
            int letters = 0;
            int cijfers = 0;
            int specialeTekens = 0;

            Console.WriteLine("geef je string in:");
            string input = Console.ReadLine();

            foreach (var character in input.ToLower())
            {
                if (character >= 97 && character <= 122)
                {
                    letters++;
                }
                else if (character >= 48 && character <= 57)
                {
                    cijfers++;
                }
                else
                {
                    specialeTekens++;
                }
                
            }

            Console.WriteLine($"Deze zin bevat {letters} letters, {cijfers} cijfers, en {specialeTekens} speciale tekens");
            Console.ReadLine();

        }
    }
}
