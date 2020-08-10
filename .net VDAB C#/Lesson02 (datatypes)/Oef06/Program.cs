using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef06
{
    class Program
    {
        static void Main(string[] args)
        {
            double prijsVolw = 35;
            double prijsTien = 25;
            double prijsKind = 20;

            Console.WriteLine("Welkom in Jonasland! het tofste pretpark van Europa!");

            Console.Write("Aantal volwassenen: ");
            int aantalVolw = Convert.ToInt32(Console.ReadLine());
            Console.Write("Aantal tieners: ");
            int aantalTien = Convert.ToInt32(Console.ReadLine());
            Console.Write("Aantal kinderen: ");
            int aantalKind= Convert.ToInt32(Console.ReadLine());

            double totaal = aantalKind*prijsKind + aantalVolw* prijsVolw + aantalTien * prijsTien;
            double totaalNaKorting = totaal;
            

            int tellerVolw = aantalVolw-1;
            int tellerTien = aantalTien-1;
            int tellerKind = aantalKind-1;

            

                double tempVolw = prijsVolw;
                double tempTien = prijsTien;
                double tempKind = prijsKind;
            while (tellerVolw > 0 || tellerTien > 0 || tellerKind > 0)
            {
                if (tellerVolw > 0) { totaalNaKorting += tempVolw; tempVolw -= (tempVolw / 100) * 10; tellerVolw--; };
                if (tellerTien > 0) { totaalNaKorting += tellerTien; tempTien -= (tellerTien / 100) * 10; tellerTien--; };
                if (tellerKind > 0) { totaalNaKorting += tempKind; tempKind -= (tempKind / 100) * 10; tellerKind--; };
            }
            Console.WriteLine(totaalNaKorting);
            Console.WriteLine();
            Console.WriteLine($"prijs per volwassene: {prijsVolw} euro");
            Console.WriteLine($"prijs per tieners: {prijsTien} euro");
            Console.WriteLine($"prijs per kinderen: {prijsKind} euro");
            Console.WriteLine();

            Console.WriteLine($"Totaal: {Math.Round(totaal,2)} euro");

            if (totaal >= 200) {
                totaalNaKorting = totaal *0.9;
            };

            Console.WriteLine($"Totaal na korting: {Math.Round(totaalNaKorting, 2)} euro");
            

            Console.ReadLine();
        }
    }
}
