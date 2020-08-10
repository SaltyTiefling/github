using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chinese_vrijwilliger_kiezer
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnjezus = new Random();
            string[] klasslijst = {"Jonas","Jonas","Martijn","Koen","Kris","Yannick","Antal","Benjamin","Dario","Latha","Machiel","Manal",
                "Niels","Scott","Sergio","Sujithra","Vic","Yura"};
                string input;
            do
            {
                Console.Write($"{klasslijst[rnjezus.Next(klasslijst.Length)]} is de uitverkorene");
                input = Console.ReadLine();
            } while (input != "end");

        }
    }
}
