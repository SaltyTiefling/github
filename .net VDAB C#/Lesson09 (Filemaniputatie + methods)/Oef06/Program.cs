using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef06
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fileLines = new List<string>();
            using (StreamWriter write = new StreamWriter("gegevens.txt"))
            {
                for (int i = 1; i <= 8; i++)
                {
                    write.WriteLine($"lijn {i}");
                }
            }

            using (StreamReader reader = new StreamReader("gegevens.txt"))
            {
                while (!reader.EndOfStream)
                {
                    fileLines.Add(reader.ReadLine());
                }
                foreach (var line in fileLines)
                {
                    Console.WriteLine(line);
                }
                    Console.ReadLine();
            }
        }
    }
}
