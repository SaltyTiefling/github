using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjectWeekJonas
{
    class Memory
    {
        static List<(char, bool)> memoryCards = new List<(char, bool)>();
        static TimeSpan viewTime = new TimeSpan(0, 0, 5);

        public static User Play(User player)
        {
            memoryCards.Clear();
            for (int i = 0; i < 2; i++)
            {
                for (int j = 3; j <= 6; j++)
                {
                    memoryCards.Add(((char)j, false));
                }
                memoryCards.Add(('A', false));
            }

            Console.WriteLine("de dealer kijkt je in de ogen en neemt $20");
            player.LoseMoney(20);
            Console.WriteLine($"Je hebt nog ${player.getMoney()}");
            if (player.broke()) Console.WriteLine("Je mag nog spelen maar als je niet wint is her over.");

            Shuffle();
            PrintMemory(true);
            Console.WriteLine("Onthoud dit!");
            Thread.Sleep(viewTime);
            bool running = true;
            int teller = 0;
            while (running)
            {
                PrintMemory();
                int card1 = InputCheckers.IntAsk("Kaart 1", 0, memoryCards.Count - 1);
                int card2 = InputCheckers.IntAsk("Kaart 2", 0, memoryCards.Count - 1);

                if (memoryCards[card1].Item1 != memoryCards[card2].Item1)
                {
                    PrintMemory(true);
                    Console.WriteLine("verkeerd! Sorry");
                    running = false;
                }
                else
                {
                    memoryCards[card1] = (memoryCards[card1].Item1, true);
                    memoryCards[card2] = (memoryCards[card2].Item1, true);
                    teller++;
                }
                if (teller >= 5)
                {
                    Console.WriteLine("We hebben een winaar!\n" +
                        "Je wint $30");
                    player.Payout(30);
                    running = false;
                }
            }

            Console.ReadLine();

            return player;
        }
        private static void Shuffle()
        {

            int i = memoryCards.Count;
            Random rng = new Random();

            while (i > 1)
            {
                i--;
                int k = rng.Next(i + 1);
                var value = memoryCards[k];
                memoryCards[k] = memoryCards[i];
                memoryCards[i] = value;
            }
        }
        private static void PrintMemory(bool reveal)
        {
            Console.Clear();
            for (int i = 0; i < memoryCards.Count; i++)
            {
                Console.Write($"  {i}  ");
            }

            Console.WriteLine();

            foreach (var card in memoryCards)
            {
                if (card.Item2 || reveal)
                {
                    switch (card.Item1)
                    {
                        case (char)3:
                            Console.ForegroundColor = ConsoleColor.Red;
                            break;
                        case (char)4:
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            break;
                        case (char)5:
                            Console.ForegroundColor = ConsoleColor.Green;
                            break;
                        case (char)6:
                            Console.ForegroundColor = ConsoleColor.Blue;
                            break;
                        case 'A':
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            break;
                        default:
                            break;
                    }
                    Console.Write($" [{card.Item1}] ");
                }
                else
                {
                    Console.Write($" [?] ");
                }
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.WriteLine();
        }
        private static void PrintMemory()
        {
            PrintMemory(false);
        }
    }
}
