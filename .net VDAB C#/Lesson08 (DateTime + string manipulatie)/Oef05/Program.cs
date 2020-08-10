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
            int teller = 0;
            DateTime date = DateTime.Now;

            while (teller < 10)
            {
                date = date.AddYears(1);
                if (DateTime.IsLeapYear(date.Year))
                {
                    Console.WriteLine($"{teller + 1}) {date.Year}");
                    teller++;
                }
            }
            Console.ReadLine();
        }
    }
}
