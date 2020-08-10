using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oef05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("oh fuck ik ruik rook. Alarm!");
            Console.Write("is er iemand thuis(Y/N)?");
            if (Console.ReadLine().ToUpper() == "Y")
            {
                Console.Write("Heeft u de situatie onder controle(Y/N)?");
                if (Console.ReadLine().ToUpper() == "Y")
                {
                    Console.WriteLine("Het alarm wordt uitgeschakeld.");
                }
                else
                {
                    Console.WriteLine("De brandweer wordt verwittigd");
                }
            }
            else
            {
                Console.WriteLine("De brandweer wordt verwittigd");
            }
            Console.ReadLine();
        }
    }
}
