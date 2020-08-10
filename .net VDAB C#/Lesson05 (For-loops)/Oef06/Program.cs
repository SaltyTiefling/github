using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef06
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int x = 1; x <= 10; x++)
                {
                    Console.Write($"{i*x}\t");
                }
                    Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
