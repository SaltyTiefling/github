using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef07
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datum = DateTime.Now;
            bool inputCorrect = false;
            Dictionary<string ,DateTime> feestdagen = new Dictionary<string, DateTime>();

            Console.WriteLine("geef de datum in:");
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

            feestdagen.Add("Pasen",new DateTime(2021, 04, 04));
            feestdagen.Add("Kerst", new DateTime(datum.Year,12,25));
            feestdagen.Add("nieuwjaar", new DateTime(datum.Year+1,1,1));
            feestdagen.Add("Hemelvaart", new DateTime(2021,5,13));
            feestdagen.Add("Wapenstilstand", new DateTime(datum.Year,11,11));
            TimeSpan kortstetijd = feestdagen.First().Value - datum;
            string kortsteFeest = feestdagen.First().Key;
            foreach (var feestdag in feestdagen)
            {
                TimeSpan controle = feestdag.Value - datum;
                if (controle < kortstetijd)
                {
                    kortsteFeest = feestdag.Key;
                    kortstetijd = controle;
                }
            }
            Console.WriteLine($"nog {kortstetijd.Days} dagen tot {kortsteFeest}");
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
