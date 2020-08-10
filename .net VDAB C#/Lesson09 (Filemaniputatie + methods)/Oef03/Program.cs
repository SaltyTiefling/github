using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef03
{
    class Program
    {
        static void Main(string[] args)
        {
            bool nieuwAangemaakt = false;
            int teller = 0;

            do
            {
                teller++;
                if (!File.Exists($"Oefening3-{teller}.txt"))
                {
                    File.Create($"Oefening3-{teller}.txt");
                    Console.WriteLine($"Oefening3-{teller}.txt is aangemaakt");
                    nieuwAangemaakt = true;
                }
                else
                {
                    Console.WriteLine($"Oefening3-{teller}.txt already exists trying Oefening3-{teller+1}.txt");
                }
            } while (!nieuwAangemaakt);
            Console.ReadLine();
        }
    }
}
