using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Reeks2_Oef10
{
    class Program
    {
        static void Main(string[] args)
        {
            bool inputcorrect = false;
            Console.Write("Geef een string in:  ");
            string input = Console.ReadLine();
            int positie = 0;
            int lengte = 0;

            do
            {
                try
                {
                    Console.Write("Geef een positie in: ");
                    if (!int.TryParse(Console.ReadLine(), out positie))
                    {
                        throw new ArgumentException("geef een geldig nummer in.");
                    }
                    else if (input.Length <= positie)
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    inputcorrect = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                    inputcorrect = false;
                }

            } while (!inputcorrect);

            inputcorrect = false;
            do
            {
                try
                {
                    Console.Write("Geef een lengte in: ");
                    if (!int.TryParse(Console.ReadLine(), out lengte))
                    {
                        throw new ArgumentException("geef een geldig nummer in.");
                    }
                    else if (!(lengte <= (input.Length - positie)))
                    {
                        throw new ArgumentOutOfRangeException();
                    }
                    inputcorrect = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.WriteLine();
                    inputcorrect = false;
                }
            } while (!inputcorrect);
            Console.WriteLine(input.Substring(positie, lengte));
            Console.ReadLine();
        }
    }
}
