using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Oef11
{
    class Program
    {
        static void Main(string[] args)
        {
            ////oef 11.1
            //List<double> getallen = new List<double>();
            //Console.WriteLine("geeft 6 getallen: ");
            //for (int i = 0; i < 6; i++)
            //{
            //    getallen.Add(Convert.ToDouble(Console.ReadLine()));
            //}

            //Console.WriteLine("---");

            //Console.WriteLine($"{getallen[0]} + {getallen[1]} = {getallen[0] + getallen[1]}");
            //Console.WriteLine($"{getallen[2]} - {getallen[3]} = {getallen[2] - getallen[3]}");
            //Console.WriteLine($"{getallen[4]} * {getallen[5]} = {getallen[4] * getallen[5]}");

            //Console.ReadLine();

            //oef 11.2
            double bloem = 500;
            double eieren = 0.5;
            double melk = 0.5;
            double boter = 0.5;

            Dictionary<string, double> winkelkar = new Dictionary<string, double>();
            winkelkar.Add("bloem", bloem);
            winkelkar.Add("eieren", eieren);
            winkelkar.Add("boter", boter);
            winkelkar.Add("melk", melk);

            double btw = winkelkar.Sum(v => v.Value) * 21 / 100;
            Console.WriteLine(winkelkar.Sum(v => v.Value));

            if (btw > 3)
            {
                winkelkar.Remove("melk");
            }

            foreach (var item in winkelkar)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

            //oef 11.3
            double prijsVolwassen = 10;
            double prijsKinderen = 10 / 2;
            double totaal = 0;
            Console.WriteLine($"de ticketen kosten {prijsVolwassen} voor volwassenen en {prijsKinderen}");
            Console.Write("met hoeveel willen jullie rijden?");
            int aantalPersonen = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < aantalPersonen; i++)
            {
                Console.Write("ben je jonger dan 10 jaar? (Y/N)");
                if (Console.ReadLine().ToUpper() == "Y") { totaal += prijsKinderen; } else { totaal += prijsVolwassen; }
            }

            Console.WriteLine($"je prijs is {totaal}");
            Console.ReadLine();

            //oef 11.4

            //oef 11.5

            //oef 11.6

            //oef 11.7

            //oef 11.8

            //oef 11.9

            //oef 11.10

            //oef 11.11

            //oef 11.12

        }
    }
}
