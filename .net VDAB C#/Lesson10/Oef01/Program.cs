using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef01
{
    class Program
    {
        static void Main(string[] args)
        {
            Notitieboekje notities = new Notitieboekje("Jonas","notieties","groen");
            Console.Write("Schrijf iets op de notitie: ");
            notities.Bijschrijven(Console.ReadLine());
            notities.Bijschrijven(Console.ReadLine());
            notities.BekijkEigenschappen();
            notities.BekijkNotities();

            Console.ReadLine();


        }
    }
}
