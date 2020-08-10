using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef02
{
    class Program
    {
        static void Main(string[] args)
        {
            string bestandsnaam = "gegevens.txt";
            if (File.Exists(bestandsnaam))
            {
                File.Delete(bestandsnaam);
                Console.WriteLine($"{bestandsnaam} is gewist");
            }
            else
            {
                File.Create(bestandsnaam);
                Console.WriteLine($"{bestandsnaam} is aangemaakt");
            }
            Console.ReadLine();
        }
    }
}
