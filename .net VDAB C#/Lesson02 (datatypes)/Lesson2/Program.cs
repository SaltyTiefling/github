using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //oefening 01
            //oef 1.1
            double getal1 = 7;
            double getal2 = 5;
            Console.WriteLine("oefening 1.1");
            Console.WriteLine();

            Console.WriteLine($"{getal1} + {getal2} = {getal1 + getal2}");
            Console.WriteLine($"{getal1} - {getal2} = {getal1 - getal2}");
            Console.WriteLine($"{getal1} * {getal2} = {getal1 * getal2}");
            Console.WriteLine($"{getal1} / {getal2} = {getal1 / getal2}");

            //oef 1.2
            Console.WriteLine();
            Console.WriteLine("oefening 1.2");

            Console.Write("Getal 1: ");
            getal1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Getal 2: ");
            getal2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"{getal1} + {getal2} = {getal1 + getal2}");
            Console.WriteLine($"{getal1} - {getal2} = {getal1 - getal2}");
            Console.WriteLine($"{getal1} * {getal2} = {getal1 * getal2}");
            Console.WriteLine($"{getal1} / {getal2} = {getal1 / getal2}");

            //oef 1.3
            Console.WriteLine();
            Console.WriteLine("oefening 1.3");

            Console.Write("Getal 1: ");
            getal1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Getal 2: ");
            getal2 = Convert.ToDouble(Console.ReadLine());

            double plus = getal1 + getal2;
            double min = getal1 - getal2;
            double maal = getal1 * getal2;
            double delen = getal1 / getal2;

            Console.WriteLine($"{getal1} + {getal2} = {plus}");
            Console.WriteLine($"{getal1} - {getal2} = {min}");
            Console.WriteLine($"{getal1} * {getal2} = {maal}");
            Console.WriteLine($"{getal1} / {getal2} = {delen}");

            double solution1 = plus + min + maal + delen;
            double solution2 = plus * min * maal * delen;

            Console.WriteLine($"{plus} + {min} + {maal} + {delen} = {solution1}");
            Console.WriteLine($"{plus} * {min} * {maal} * {delen} = {solution2}");
            
            //oef 1.4
            Console.WriteLine();
            Console.WriteLine("oefening 1.3");

            Console.Write("Getal 1: ");
            getal1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Getal 2: ");
            getal2 = Convert.ToDouble(Console.ReadLine());

            plus = (getal1 + getal2);
            min = (getal1 - getal2);
            maal = (getal1 * getal2);
            delen = (getal1 / getal2);

            Console.WriteLine($"{getal1} + {getal2} = {Math.Round(plus,2)}");
            Console.WriteLine($"{getal1} - {getal2} = {Math.Round(min,2)}");
            Console.WriteLine($"{getal1} * {getal2} = {Math.Round(maal,2)}");
            Console.WriteLine($"{getal1} / {getal2} = {Math.Round(delen,2)}");

            solution1 = plus + min + maal + delen;
            solution2 = plus * min * maal * delen;

            Console.WriteLine($"{plus} + {min} + {maal} + {delen} = {Math.Round(solution1,2)}");
            Console.WriteLine($"{plus} * {min} * {maal} * {delen} = {Math.Round(solution2,2)}");

            //End of program
            Console.ReadLine();

        }
    }
}