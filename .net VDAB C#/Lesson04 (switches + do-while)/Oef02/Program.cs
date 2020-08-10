using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Maand: ");
            string maand = "";
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    maand = "Januari";
                    break;
                case 2:
                    maand = "Februari";
                    break;
                case 3:
                    maand = "Maart";
                    break;
                case 4:
                    maand = "April";
                    break;
                case 5:
                    maand = "Mei";
                    break;
                case 6:
                    maand = "Juni";
                    break;
                case 7:
                    maand = "Juli";
                    break;
                case 8:
                    maand = "Augustus";
                    break;
                case 9:
                    maand = "September";
                    break;
                case 10:
                    maand = "October";
                    break;
                case 11:
                    maand = "November";
                    break;
                case 12:
                    maand = "December";
                    break;

                default:
                    Console.WriteLine("error");
                    break;
            }
            Console.WriteLine($"Deze maand is {maand}");
            Console.ReadLine();
        }
    }
}
