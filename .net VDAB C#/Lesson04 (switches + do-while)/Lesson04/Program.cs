using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Op een schaal van 1-3, wat is je niveau?: ");
            
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Console.WriteLine("jij bent een junior");
                    break;
                case 2:
                    Console.WriteLine("jij bent een medior");
                    break;
                case 3:
                    Console.WriteLine("jij bent een senior");
                    break;
                default:
                    Console.WriteLine("error");
                    break;
            }

            Console.ReadLine();
        }
    }
}
