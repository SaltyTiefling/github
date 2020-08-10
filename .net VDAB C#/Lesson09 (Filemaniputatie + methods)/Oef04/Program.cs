using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef04
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter write = new StreamWriter("gegevens.txt"))
            {
                for (int i = 1; i <= 8; i++)
                {
                    write.WriteLine($"lijn {i}");
                }
            }
            using (StreamReader reader = new StreamReader("gegevens.txt"))
            {
                foreach (var item in reader.ReadToEnd())
                {
                    Console.Write(item);
                }
            }
            Console.ReadLine();
        }
    }
}
