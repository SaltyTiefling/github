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
            DateTime datum = DateTime.Now;
            bool inputCorrect = false;

            Console.WriteLine("geef datum in:");
            do
            {
                try
                {
                    datum = new DateTime(
                        inputCheckInt("Year"),
                        inputCheckInt("Month"),
                        inputCheckInt("Day"));
                    inputCorrect = true;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    inputCorrect = false;
                }
            } while (!inputCorrect);
            Console.WriteLine($"it's a {datum.DayOfWeek}");
            Console.ReadLine();
            
        }
        static int inputCheckInt(string question)
        {
            int result = 0;
            bool inputCorrect = false;

            do
            {
                try
                {
                    Console.Write($"{question}: ");
                    result = Convert.ToInt32(Console.ReadLine());
                    inputCorrect = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
            } while (!inputCorrect);
            return result;
        }
    }
}
