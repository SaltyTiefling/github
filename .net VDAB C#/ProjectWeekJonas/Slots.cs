using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml;

namespace ProjectWeekJonas
{
    class Slots
    {
        static char[] icons = new char[7] { '☺', (char)6, (char)5, (char)4, (char)3, 'A', '7' };
        static char[,] playBoard = new char[3, 3];
        static Random rng = new Random();
        internal static User Play(User player)
        {
            FillBoard();

            Console.Clear();
            Console.WriteLine("de dealer kijkt je in de ogen en neemt $5");
            player.LoseMoney(5);
            Console.WriteLine($"Je hebt nog ${player.getMoney()}");
            if (player.broke()) Console.WriteLine("Je mag nog spelen maar als je niet wint is her over.");
            Console.ReadLine();

            bool running = true;
            int speed = 50;
            Console.CursorVisible = false;
            for (int i = 0; i < 100; i++)
            {
                if (i <= 50)
                {
                    playBoard[2, 0] = playBoard[1, 0];
                    playBoard[1, 0] = playBoard[0, 0];
                    playBoard[0, 0] = icons[rng.Next(0, 7)];
                }
                else speed = 100;

                if (i <= 75)
                {
                    playBoard[0, 1] = playBoard[1, 1];
                    playBoard[1, 1] = playBoard[2, 1];
                    playBoard[2, 1] = icons[rng.Next(0, 7)];
                }
                else speed = 200;

                playBoard[2, 2] = playBoard[1, 2];
                playBoard[1, 2] = playBoard[0, 2];
                playBoard[0, 2] = icons[rng.Next(0, 7)];

                PrintPlayboard();
                Thread.Sleep(speed);
            }
            Console.CursorVisible = true;

            double winnings = checkWinnings();

            Console.WriteLine($"You win {winnings}");
            player.Payout(winnings);
            Console.ReadLine();
            return player;
        }

        private static double checkWinnings()
        {
            double output = 0;
            List<char> winningchars = new List<char>();
            for (int i = 0; i < 3; i++)
            {
                // rows
                if (playBoard[i, 0] == playBoard[i, 1] && playBoard[i, 0] == playBoard[i, 2])
                {
                    winningchars.Add(playBoard[i, 0]);
                }
                // columns
                if (playBoard[0, i] == playBoard[1, i] && playBoard[0, i] == playBoard[2, i])
                {
                    winningchars.Add(playBoard[0, i]);
                }
            }
            // line: \
            if (playBoard[0, 0] == playBoard[1, 1] && playBoard[0, 0] == playBoard[2, 2])
            {
                winningchars.Add(playBoard[0, 0]);
            }
            // line: /
            if (playBoard[2, 0] == playBoard[1, 1] && playBoard[2, 0] == playBoard[0, 2])
            {
                winningchars.Add(playBoard[0, 0]);
            }
            foreach (var character in winningchars)
            {
                switch (character)
                {
                    case (char)3:
                        output += 20;
                        break;
                    case (char)4:
                        output += 10;
                        break;
                    case (char)5:
                        output += 7;
                        break;
                    case (char)6:
                        output += 5;
                        break;
                    case 'A':
                        output += 50;
                        break;
                    case '7':
                        output += 100;
                        break;
                    case '☺':
                        output += 3;
                        break;
                    default:
                        break;
                }
            }

            return output;
        }

        private static void PrintPlayboard()
        {
            Console.SetCursorPosition(0, 3);
            for (int i = 0; i < 3; i++)
            {
                Console.Write("[ ");
                for (int j = 0; j < 3; j++)
                {
                    switch (playBoard[i, j])
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
                        case '7':
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            break;
                        case '☺':
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            break;
                        default:
                            break;
                    }
                    Console.Write($"{playBoard[i, j]} ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.WriteLine("]");
            }
        }

        private static void FillBoard()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    playBoard[i, j] = icons[rng.Next(0, 7)];
                }
            }

        }
    }
}
