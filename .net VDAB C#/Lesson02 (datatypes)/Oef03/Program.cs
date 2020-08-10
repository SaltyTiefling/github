using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Fahrenheit: ");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            double celsius = (fahrenheit - 32)*5 / 9;
            Console.WriteLine($"Celsius: {Math.Round(celsius)}");
            Console.WriteLine($"Celsius zonder afronding: {celsius}");
            Console.ReadLine();
        }
    }
}
