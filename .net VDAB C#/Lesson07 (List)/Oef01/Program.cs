using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef01
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = 0;
            bool inputCorrect = false;
            List<string> personen = new List<string>();
            do
            {
                try
                {
                    Console.Clear();
                    Console.Write("Aantal personen (3-10): ");
                    length = Convert.ToInt32(Console.ReadLine());
                    if (length > 10 || length < 3) throw new ArgumentException();
                    inputCorrect = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                    inputCorrect = false;
                }

            } while (!inputCorrect);
            for (int i = 0; i < length; i++)
            {
                inputCorrect = false;
                do
                {
                    try
                    {
                        Console.Write($"Persoon {i + 1}: ");
                        personen.Add(Console.ReadLine());
                        inputCorrect = true;
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        inputCorrect = false;
                    }
                } while (!inputCorrect);
            }

            foreach (var persoon in personen)
            {
                Console.WriteLine(persoon);
            }

            inputCorrect = false;
            do
            {
                try
                {
                    Console.Write($"wilt u een persoon verwijderen (Y/N): ");

                    switch (Console.ReadLine().ToLower())
                    {
                        case "y":
                        case "j":
                        case "ja":
                        case "yes":
                            do
                            {
                                try
                                {
                                    Console.Write("wie wil je verwijderen?");
                                    personen.Remove(Console.ReadLine());
                                    inputCorrect = true;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                    inputCorrect = false;
                                }

                            } while (!inputCorrect);
                            break;
                        case "n":
                        case "nee":
                        case "no":

                            inputCorrect = true;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    inputCorrect = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    inputCorrect = false;
                }
            } while (!inputCorrect);

            foreach (var persoon in personen)
            {
                Console.WriteLine(persoon);
            }
            inputCorrect = false;
            do
            {
                try
                {
                    Console.Write($"wilt u nog een persoon verwijderen (Y/N)? ");

                    switch (Console.ReadLine().ToLower())
                    {
                        case "y":
                        case "j":
                        case "ja":
                        case "yes":
                            do
                            {
                                try
                                {
                                    Console.Write("wie wil je verwijderen?(indexnr): ");
                                    personen.RemoveAt(Convert.ToInt32(Console.ReadLine()));
                                    inputCorrect = true;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine(e.Message);
                                    inputCorrect = false;
                                }

                            } while (!inputCorrect);
                            break;
                        case "n":
                        case "nee":
                        case "no":

                            inputCorrect = true;
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    inputCorrect = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    inputCorrect = false;
                }
            } while (!inputCorrect);

            personen.Sort();
            personen.Reverse();

            foreach (var persoon in personen)
            {
                Console.WriteLine(persoon);
            }


            Console.Write("wil je de personen veranderen naar hoofdletter, kleine letters of zo laten?: ");
            switch (Console.ReadLine().ToLower())
            {
                case "hoofd":
                case "hoofdletters":
                case "h":
                case "upper":
                case "uppercase":
                    personen = personen.ConvertAll(persoon => persoon.ToUpper());
                    Console.WriteLine("uppercase");
                    break;
                case "klein":
                case "kleine letters":
                case "k":
                case "lower":
                case "lowercase":
                    personen = personen.ConvertAll(persoon => persoon.ToLower());
                    break;
                default:
                    break;
            }

            int teller = 0;
            foreach (var persoon in personen)
            {
                teller++;
                Console.WriteLine($"{teller}) {persoon}");
            }
            personen.Clear();
            Console.ReadLine();

        }
    }
}
