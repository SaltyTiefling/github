using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef08
{
    class Program
    {
        static void Main(string[] args)
        {
            int buizen = 0;
            string[] vakken = { "Wiskunde", "Aardrijkskunde", "Economie", "Geschiedenis", "Frans", "Nederlands", "Engels", "ICT"};
            Dictionary<string, double> rapport = new Dictionary<string, double>();

            foreach (var vak in vakken)
            {
                Console.Write($"{vak}: ");
                double punten = Convert.ToDouble(Console.ReadLine());
                rapport.Add(vak, punten);
                if (punten < 50)
                {
                    buizen++;
                }
            }
            double gemiddelde = Math.Round(rapport.Average(t => t.Value),2);
            Console.WriteLine($"je hebt {buizen} buizen.");
            Console.WriteLine($"jouw gemiddelde is {gemiddelde}");
            Console.ReadLine();

        }
    }
}
