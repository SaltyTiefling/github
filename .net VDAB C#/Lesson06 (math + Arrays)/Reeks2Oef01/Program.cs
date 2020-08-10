using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reeks2Oef01
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] getallenlijst = new int[5] {5, 8, 9, 10, 55 };

            for (int i = 0; i < getallenlijst.Length; i++)
            {
                Console.WriteLine($"Getal {i+1}: {getallenlijst[i]}");
            }
            Console.ReadLine();
        }
    }
}
