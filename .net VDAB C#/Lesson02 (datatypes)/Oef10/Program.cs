using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef10
{
    class Program
    {
        static void Main(string[] args)
        {
            int getal1 = 0;
            int getal2 = 1;
            
            while (getal2 < 4000)
            {
                Console.Write(" "+ getal1);
                int temp = getal1+getal2;
                getal1 = getal2;
                getal2 = temp;

            }
            Console.ReadLine();
            
        }
    }
}
