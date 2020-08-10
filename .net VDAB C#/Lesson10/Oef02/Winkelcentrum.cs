using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Oef02
{
    class Winkelcentrum
    {
        static List<Winkel> winkels = new List<Winkel>();
        public static void Main(string[] args)
        {
            winkels.Add(new Winkel());
            winkels.Add(new Winkel("test2", "testspecialisatie2", new List<Product>{
            new Product("matrass","waar je op licht", 65.23, 7),
            new Product("kussen", "waar je hoofd op ligt",10,3),
            new Product("bed", "de frame van het bed", 600,20),
            new Product("moeder", "maakt je bed op", 0.20, 1),
            new Product("nachtkastje", "De all new Fjortigut", 4555, 800)
            }));

            List<string> winkelnamen = new List<string>();

            foreach (var winkelnaam in winkels)
            {
                winkelnamen.Add(winkelnaam.naam);
            }

            int winkelindex = SelectMenu(winkelnamen.ToArray()) - 1;

            Product product = winkels[winkelindex].productenLijst[SelectMenu(winkels[winkelindex].PrintProducten().ToArray()) - 1];

            switch (SelectMenu($"voeg {product.naam} toe aan winkelkar",
                       $"herstock {product.naam}",
                       $"Close"))
            {
                case 1:
                    winkels[winkelindex].steekInWinkelkarretje(product);
                    break;
                case 2:
                    bool inputcorrect = false;

                    do
                    {
                        Console.Clear();
                        Console.Write("hoeveel wil je bijstockeren: ");
                        try
                        {
                            product.addstock(Convert.ToInt32(Console.ReadLine()));
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.Message);
                            Console.ReadLine();
                        }


                    } while (!inputcorrect);


                    break;
                default:
                    break;
            }



            Console.ReadLine();
        }
        static int SelectMenu(params string[] menu)
        {
            Console.CursorVisible = false;
            Console.Clear();

            int selection = 1;
            bool selected = false;

            ConsoleColor selectionForeground = Console.BackgroundColor;
            ConsoleColor selectionBackground = Console.ForegroundColor;

            while (!selected)
            {
                int teller = 0;
                foreach (var item in menu)
                {
                    teller++;

                    if (selection == teller)
                    {
                        Console.ForegroundColor = selectionForeground;
                        Console.BackgroundColor = selectionBackground;
                    }

                    Console.WriteLine(teller + ": " + item);
                    Console.ResetColor();
                }

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        selection--;
                        break;
                    case ConsoleKey.DownArrow:
                        selection++;
                        break;
                    case ConsoleKey.Enter:
                        selected = true;
                        break;
                }

                selection = Math.Min(Math.Max(selection, 1), menu.Length);

                //Console.Clear();
                Console.SetCursorPosition(0, 0);
            }

            Console.Clear();
            Console.CursorVisible = true;
            return selection;
        }

    }
}
