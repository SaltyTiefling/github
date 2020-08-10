using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {
        static string word;
        static void Main(string[] args)
        {
            //Console.OutputEncoding = System.Text.Encoding.Unicode;
            //Dictionary<string, bool> guesses = new Dictionary<string, bool>();

            //Console.WriteLine("welcome to hangman: Please fill in your word/sentence");
            //string word = Console.ReadLine().ToUpper();

            //Console.Clear();
            //bool victory = false;

            //int misses = 0;
            //while (!victory && misses < 8)
            //{
            //    Console.Write("Take your guess: ");
            //    string guess = Console.ReadLine();
            //    Console.WriteLine();
            //    if (guess == word)
            //    {
            //        victory = true;
            //    }

            //    misses++;
            //    if (word.Contains(guess) && guess.Length <= 1)
            //    {
            //        misses--;


            //    }
            //    //print word

            //    printHangman(misses);
            //    Console.Write("guesses:");
            //    foreach (var character in guessedChars)
            //    {
            //        Console.Write(" " + character);
            //    }
            //    Console.WriteLine();
            //}
            for (int i = 0; i <= 8; i++)
            {
                printHangman(i);
                Console.ReadLine();
            }
        }
        static public void printHangman(int misses)
        {
            printHangman(misses, 0, 0);
        }
        static public void printHangman(int misses, int cursorLeft, int cursorTop)
        {
            if (misses >= 1)
            {
                Console.SetCursorPosition(cursorLeft + 0, cursorTop + 8);
                Console.WriteLine("╠════════╗ \n");
                Console.SetCursorPosition(cursorLeft + 0, cursorTop + 9);
                Console.WriteLine("╨        ╨");
            }
            if (misses >= 2)
            {
                Console.SetCursorPosition(cursorLeft + 0, cursorTop + 1);
                Console.WriteLine("╔═════╤═\n");
                for (int i = 1; i <= 6; i++)
                {
                    Console.SetCursorPosition(cursorLeft + 0, cursorTop + 1 + i);
                    Console.WriteLine("║ \n");
                }
            }
            if (misses >= 3)
            {
                Console.SetCursorPosition(cursorLeft + 6, cursorTop + 2);
                Console.WriteLine("│");
                Console.SetCursorPosition(cursorLeft + 4, cursorTop + 3);
                Console.WriteLine("(ò-ó)");
            }
            if (misses >= 4)
            {
                for (int i = 4; i <= 5; i++)
                {
                    Console.SetCursorPosition(cursorLeft + 6, cursorTop + i);
                    Console.WriteLine("█");
                }
            }
            if (misses >= 5)
            {
                Console.SetCursorPosition(cursorLeft + 4, cursorTop + 4);
                Console.WriteLine("╔═");
                Console.SetCursorPosition(cursorLeft + 4, cursorTop + 5);
                Console.WriteLine("▀");
                Console.SetCursorPosition(cursorLeft + 7, cursorTop + 4);
                Console.WriteLine("═╗");
                Console.SetCursorPosition(cursorLeft + 8, cursorTop + 5);
                Console.WriteLine("▀");
            }
            if (misses >= 6)
            {
                Console.SetCursorPosition(cursorLeft + 6, cursorTop + 6);
                Console.WriteLine("║");
                Console.SetCursorPosition(cursorLeft + 6, cursorTop + 7);
                Console.WriteLine("╨");
            }
            if (misses >= 7)
            {
                Console.SetCursorPosition(cursorLeft + 4, cursorTop + 3);
                Console.WriteLine("(>->) come on it's easy... I don't wanna die");
            }
            if (misses >= 8)
            {
                Console.SetCursorPosition(cursorLeft + 4, cursorTop + 3);
                Console.WriteLine("(X¬X)                                        ");
            }

            Console.SetCursorPosition(cursorLeft + 12, cursorTop + 4);
            Console.WriteLine((misses < 8) ? $" {8 - misses} more chance" : $"You lose, better luck next time");
            Console.SetCursorPosition(0, cursorTop + 10);
        }
    }
}
