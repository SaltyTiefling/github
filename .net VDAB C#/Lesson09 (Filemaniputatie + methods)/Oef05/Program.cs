using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef05
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileLines = {"lijn 1", "lijn 2","lijn 3"};
            using (StreamWriter writer = new StreamWriter("gegevens.txt"))
            {
                foreach (var line in fileLines)
                {
                    writer.WriteLine(line);
                }
            }
        }
    }
}
