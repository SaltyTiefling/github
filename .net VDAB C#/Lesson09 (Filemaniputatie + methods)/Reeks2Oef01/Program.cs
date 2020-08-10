using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Reeks2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool running = true;
            do
            {
                Console.WriteLine("Type pick 0 to end");
                switch (inputCheckInt("Oef"))
                {
                    case 0:
                        running = false;
                        break;
                    case 1:
                        Console.WriteLine("dit is oefening 1");
                        Console.ReadLine();
                        break;
                    case 2:
                        Reeks2Oef02();
                        break;
                    case 3:
                        Reeks2Oef03();
                        break;
                    case 4:
                        Reeks2Oef04();
                        break;
                    case 5:
                        Reeks2Oef05();
                        break;
                    case 6:
                        Reeks2Oef06();
                        break;
                    case 7:
                        Reeks2Oef07();
                        break;
                    case 8:
                        Reeks2Oef08();
                        break;
                    default:
                        break;
                }
                Console.Clear();
            } while (running);
        }

        private static void Reeks2Oef08()
        {
            bool running = true;
            do
            {
                int number = inputCheckInt("welke cijfers wil je optellen (0 for end)");
                if (number == 0)
                {
                    running = false;
                }
                else
                {
                    int result = TelCijfersOp(number);
                    Console.WriteLine(result);
                }
                Console.ReadLine();
            } while (running);
        }


        private static void Reeks2Oef07()
        {
            bool running = true;
            do
            {
                int number = inputCheckInt("how much of Fibonacci do you want to see? (0 for end)");
                if (number == 0)
                {
                    running = false;
                }
                else
                {
                    foreach (var getal in Fibonacci(number))
                    {
                        Console.Write($"{getal} ");
                    }
                    Console.ReadLine();
                }
            } while (running);
        }

        private static void Reeks2Oef06()
        {
            bool running = true;
            do
            {
                int getal1 = inputCheckInt("getal1 (0 for end)");
                int getal2 = inputCheckInt("getal2");
                if (getal1 == 0)
                {
                    running = false;
                }
                else
                {
                    foreach (var getal in SwitchTwoNumbers(getal1, getal2))
                    {
                        Console.Write($"{getal} ");
                    }
                    Console.ReadLine();
                }
            } while (running);
        }

        private static void Reeks2Oef05()
        {
            bool running = true;
            do
            {
                int input = inputCheckInt("hoeveel personen wil je ingeven? (0 for end)");
                if (input == 0)
                {
                    running = false;
                }
                else
                {
                    List<string> names = new List<string>();
                    for (int i = 0; i < input; i++)
                    {
                        names.Add(Console.ReadLine());
                    }
                    names.Sort();
                    foreach (var name in names)
                    {
                        Console.WriteLine(name);
                    }
                    Console.ReadLine();
                }
            } while (running);
        }

        private static void Reeks2Oef04()
        {
            bool running = true;
            do
            {
                int input = inputCheckInt("hoeveel getallen wil je optellen? (0 for end)");
                if (input == 0)
                {
                    running = false;
                }
                else
                {
                    int[] numbers = new int[input];
                    for (int i = 0; i < numbers.Length; i++)
                    {
                        numbers[i] = inputCheckInt($"getal {i + 1}");
                    }
                    Console.WriteLine(Calculator('+',numbers));
                    Console.ReadLine();
                }
            } while (running);
        }

        private static void Reeks2Oef03()
        {
            bool running = true;
            do
            {
                int getal = inputCheckInt("waar wil je de faculteit van weten? (0 for end)");
                if (getal == 0)
                {
                    running = false;
                }
                else
                {
                    int result = getal;
                    for (int i = 1; i < getal; i++)
                    {
                        result *= i;
                    }
                    Console.WriteLine(result);
                }
            } while (running);
            Console.ReadLine();
        }

        static public void Reeks2Oef02()
        {
            bool running = true;
            do
            {
                int getal1 = inputCheckInt("getal1");
                int getal2 = inputCheckInt("getal2");
                Console.WriteLine("wil je...");
                Console.WriteLine(
                    "0) go back\n" +
                    "1) Optellen\n" +
                    "2) Aftrekken\n" +
                    "3) Vermenigvuldigen\n" +
                    "4) Delen"
                    );

                switch (inputCheckInt("choice"))
                {
                    case 0:
                        running = false;
                        break;
                    case 1:
                        Console.WriteLine(Calculator('+', getal1, getal2));
                        break;
                    case 2:
                        Console.WriteLine(Calculator('-', getal1, getal2));
                        break;
                    case 3:
                        Console.WriteLine(Calculator('*', getal1, getal2));
                        break;
                    case 4:
                        Console.WriteLine(Calculator('/', getal1, getal2));
                        break;
                    default:
                        break;
                }
            } while (running);
        }

        private static int[] SwitchTwoNumbers(int getal1, int getal2)
        {
            int[] output = new int[2];
            output[1] = getal1;
            output[0] = getal2;

            return output;

        }

        private static int[] Fibonacci(int number)
        {
            List<int> output = new List<int>();
            int number1 = 0, number2 = 1, number3;
            output.Add(number1);
            output.Add(number2);

            for (int i = 2; i < number; ++i) //loop starts from 2 because 0 and 1 are already printed    
            {
                number3 = number1 + number2;
                output.Add(number3);
                number1 = number2;
                number2 = number3;
            }

            return output.ToArray();
        }

        static public int Calculator(char calculation, params int[] getallen)
        {
            int output = 0;
            if (calculation == '+') output = 0;
            if (calculation == '-') output = getallen[0] *2;
            if (calculation == '*') output = 1;
            if (calculation == '/') output = getallen[0] * getallen[0];


            foreach (var getal in getallen)
            {
                if (calculation == '+') output += getal;
                if (calculation == '-') output -= getal;
                if (calculation == '*') output *= getal;
                if (calculation == '/') output /= getal;
            }
            return  output;

        }
        /*
        static public int Optellen(params int[] getallen)
        {
            int output = 0;
            foreach (var getal in getallen)
            {
                output += getal;
            }
            return output;
        }

        static public int Aftrekken(params int[] getallen)
        {
            int output = getallen[0] * 2;
            foreach (var getal in getallen)
            {
                output -= getal;
            }
            return output;
        }

        static public int Vermenigvuldigen(params int[] getallen)
        {
            int output = 1;
            foreach (var getal in getallen)
            {
                output *= getal;
            }
            return output;
        }

        static public int Delen(params int[] getallen)
        {
            int output = getallen[0] * getallen[0];
            foreach (var getal in getallen)
            {
                output /= getal;
            }
            return output;
        }
        */
        static public int inputCheckInt(string vraag)
        {
            int output = 0;
            bool inputCorrect = false;
            do
            {
                try
                {
                    Console.Write($"{vraag}: ");
                    output = Convert.ToInt32(Console.ReadLine());
                    inputCorrect = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!inputCorrect);
            return output;

        }
        private static int TelCijfersOp(int numbers)
        {
            int result = 0;
            foreach (var number in numbers.ToString())
            {
                Console.WriteLine(number);
                result += Convert.ToInt32(number.ToString());
            }

            return result;
        }

    }
}
