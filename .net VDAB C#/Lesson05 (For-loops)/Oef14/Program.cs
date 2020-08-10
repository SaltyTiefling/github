using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef14
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 15; i++)
            {
                string binary = Convert.ToString(i, 2);
                for (int j = 1; j <= 4-binary.Length; j++)
                {
                    Console.Write("0");
                }
                Console.Write($"{binary} ");
            }
            Console.ReadLine();
        }
    }
}
