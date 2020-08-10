using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Maand: ");
            int maand = 0;
            switch (Console.ReadLine().ToLower())
            {
                case "januari":
                    maand = 1;
                    break;
                case "februari":
                    maand = 2;
                    break;
                case "maart":
                    maand = 3;
                    break;
                case "april":
                    maand = 4;
                    break;
                case "mei":
                    maand = 5;
                    break;
                case "juni":
                    maand = 6;
                    break;
                case "juli":
                    maand = 7;
                    break;
                case "augustus":
                    maand = 8;
                    break;
                case "september":
                    maand = 9;
                    break;
                case "october":
                    maand = 10;
                    break;
                case "november":
                    maand = 11;
                    break;
                case "December":
                    maand = 12;
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }
            Console.WriteLine($"Deze maand is de {maand}e maand.");
            Console.ReadLine();
        }
    }
}
