using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef08
{
    class Program
    {
        static void Main(string[] args)
        {
            string bestandsnaam = "gegevens";
            File.Create($"{bestandsnaam}.txt").Dispose();
            if (File.Exists($"{bestandsnaam} - Copy.txt"))
            {
                File.Delete($"{bestandsnaam} - Copy.txt");
            }
                File.Copy($"{bestandsnaam}.txt", $"{bestandsnaam} - Copy.txt");
        }
    }
}
