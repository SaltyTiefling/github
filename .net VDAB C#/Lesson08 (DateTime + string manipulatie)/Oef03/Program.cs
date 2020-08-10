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
            DateTime datum = DateTime.Now;
            bool inputCorrect = false;


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

            int doy = datum.DayOfYear - Convert.ToInt32((DateTime.IsLeapYear(datum.Year)) && datum.DayOfYear > 59);

            if (doy < 80 || doy >= 355) Console.WriteLine("Winter");

            if (doy >= 80 && doy < 172) Console.WriteLine("Lente");

            if (doy >= 172 && doy < 266) Console.WriteLine("Zomer");

            else Console.WriteLine("Winter");
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
