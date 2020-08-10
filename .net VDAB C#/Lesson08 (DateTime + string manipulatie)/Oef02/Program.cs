using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef02
{
    class Program
    {
        static void Main(string[] args)
        {
            bool inputCorrect = false;
            DateTime maand = DateTime.Now;
            do
            {
                Console.Clear();
                Console.Write("geef een maand in (nummer):");
                try
                {
                    int input = Convert.ToInt32(Console.ReadLine());
                    maand = new DateTime(1, input, 1);
                    inputCorrect = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                    inputCorrect = false;
                }
            } while (!inputCorrect);
            switch (maand.Month)
            {
                case 1:
                case 2:
                case 3:
                    Console.WriteLine("1e kwartaal");
                    break;
                    case 4:
                case 5:
                case 6:
                    Console.WriteLine("2e kwartaal");
                    break;
                case 7:
                case 8:
                case 9:
                    Console.WriteLine("3e kwartaal");
                    break;
                case 10:
                case 11:
                case 12:
                    Console.WriteLine("4e kwartaal");
                    break;
                default:
                    break;
            }
            Console.ReadLine();
        }
    }
}
