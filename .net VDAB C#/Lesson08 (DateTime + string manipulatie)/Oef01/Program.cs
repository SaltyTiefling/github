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
            DateTime vandaag = DateTime.Now;
            DateTime over14Days = DateTime.Now.AddDays(14);

            Console.WriteLine($"over 14 dagen is het {over14Days}");
            Console.ReadLine();
        }
    }
}
