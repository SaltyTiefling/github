using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef09
{
    class Program
    {
        static void Main(string[] args)
        {

            string input = "";
            do
            {
                string[] files = Directory.GetFiles(Directory.GetCurrentDirectory(), "*.txt");
                int teller = 0;

                foreach (var item in files)
                {
                    files[teller] = item.Replace(Directory.GetCurrentDirectory() + "\\", "");
                    teller++;
                }

                Console.WriteLine("----------------");

                foreach (var item in files)
                {
                    Console.WriteLine($"- {item}");
                }

                Console.WriteLine("----------------");
                Console.WriteLine("If you want add a txt file please say \"add \" and then it's name.");
                Console.WriteLine("If you want to delete one say \"delete \" and then it's name.");
                input = Console.ReadLine();
                string command = input.Split(' ').First().ToLower();
                string filename = input.Replace($"{input.Split(' ').First()} ","") + ".txt";

                switch (command)
                {
                    case "add":
                        File.Create(filename).Dispose();
                        break;
                    case "delete":
                        File.Delete(filename);
                        break;
                    default:
                        Console.WriteLine("give valid input");
                        break;
                }

                Console.ReadLine();

            } while (input != "exit");
        }
    }
}
