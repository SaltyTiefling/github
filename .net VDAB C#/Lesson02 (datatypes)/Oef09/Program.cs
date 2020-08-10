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
            Console.Write("Af te leggen afstand in km: ");
            double afstand = Convert.ToDouble(Console.ReadLine());
            Console.Write("Snelheid in km/h: ");
            double snelheid = Convert.ToDouble(Console.ReadLine());
            TimeSpan tijd = TimeSpan.FromHours(afstand/snelheid);
            Console.WriteLine($"Decimal vrachtwagen zal nog {tijd.Hours} uur, {tijd.Minutes} minuten, {tijd.Seconds} seconden en {tijd.Milliseconds} milliseconden moeten rijden");

            Console.ReadLine();
        }
    }
}
