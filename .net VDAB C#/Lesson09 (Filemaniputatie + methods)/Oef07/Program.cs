using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef07
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> fileContent = new List<string>();
            bool inputCorrect = false;

            string input = "";
            Console.Write("what document would you like to change: ");
            string bestandsnaam = Console.ReadLine();

            if (!File.Exists(bestandsnaam))
            {
                do
                {
                    inputCorrect = false;
                    try
                    {
                        using (StreamWriter write = new StreamWriter(bestandsnaam))
                        {
                            Console.WriteLine("bestand is aangemaakt");
                        }
                        inputCorrect = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                } while (!inputCorrect);
            }
            

            using (StreamReader reader = new StreamReader(bestandsnaam))
            {
                while (!reader.EndOfStream)
                {
                    fileContent.Add(reader.ReadLine());
                }
            }
            do
            {
                Console.Clear();
                Console.WriteLine("what line would you like to change?");
                
                foreach (var line in fileContent)
                {
                    Console.WriteLine($"{fileContent.IndexOf(line)}) \"{line}\"");
                }
                Console.WriteLine($"{fileContent.Count()}) add new line");
                Console.WriteLine("enter \"exit\" to end the program");
                Console.Write("choice: ");
                input = Console.ReadLine();
                try
                {
                    if (Convert.ToInt32(input) >= fileContent.Count())
                    {
                        Console.WriteLine($"What line would you like to add?");
                        fileContent.Add(Console.ReadLine());
                    }
                    else
                    {
                        Console.WriteLine("would you like to \"change\" or \"delete\"");
                        do
                        {
                            inputCorrect = false;
                            switch (Console.ReadLine().ToLower())
                            {
                                case "delete":
                                    fileContent.RemoveAt(Convert.ToInt32(input));
                                    inputCorrect = true;
                                    break;
                                case "change":
                                    Console.WriteLine($"old: {fileContent[Convert.ToInt32(input)]}");
                                    Console.Write($"new: ");
                                    fileContent[Convert.ToInt32(input)] = Console.ReadLine();
                                    inputCorrect = true;
                                    break;
                                default:
                                    Console.WriteLine("give valid choice");
                                    break;
                            }

                        } while (!inputCorrect);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                using (StreamWriter write = new StreamWriter(bestandsnaam))
                {
                    foreach (var line in fileContent)
                    {
                        write.WriteLine(line);
                    }
                }
            } while (input.ToLower() != "exit");

        }
    }
}
