using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Steam_Client
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = 0;
            bool exit = false;
            do
            {
                choice = 0;
                do
                {
                    Console.Clear();
                    Console.WriteLine("welcome to steam:");
                    Console.WriteLine("What game you wanna play?");
                    Console.WriteLine("1. Higher/Lower");
                    Console.WriteLine("2. Blackjack (simplified)");
                    Console.WriteLine("3. Rock Paper Scissors");
                    Console.WriteLine("4. Close");
                    Console.WriteLine();
                    Console.Write("Game: ");
                } while (int.TryParse(Console.ReadLine(), out choice) && (choice < 1 || choice > 4));
                switch (choice)
                {
                    case 1:
                        HigherLower();
                        break;
                    case 2:
                        Blackjack();
                        break;
                    case 3:
                        RockPaperScissors();
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        break;
                }
            } while (!exit);
            Console.WriteLine("Thanks for playing with us");
            Console.ReadLine();
        }

        private static void RockPaperScissors()
        {
            string[] options = { "Rock", "Paper", "Scissors" };
            Console.Clear();
            string playerHand = "";
            do
            {
                Console.WriteLine("Rock, paper or scissors?");
                playerHand = Console.ReadLine();
            } while (!IsPlayable(playerHand));

            Random rnd = new Random();
            string opponentHand = options[rnd.Next(0,3)];
            Console.WriteLine($"the computer plays {opponentHand} so you {winLostDraw(playerHand,opponentHand)}");
            Console.ReadLine();

            bool IsPlayable(string input)
            {
                switch (input.ToLower())
                {
                    case "rock":
                    case "paper":
                    case "scissors":
                        return true;
                    default:
                        return false;
                }
            }

            string winLostDraw(string player, string opponent)
            {
                player = player.ToLower();
                opponent = opponent.ToLower();

                if (player == "rock")
                {
                    if (opponent == "paper")
                    {
                        return "Lost";
                    }
                    else if (opponent == "scissors")
                    {
                        return "Win";
                    }
                    else if (opponent == "rock")
                    {
                        return "draw";
                    }
                    else
                    {
                        return "The opponent played an invalid hand";
                    }
                }
                else if (player == "paper")
                {
                    if (opponent == "paper")
                    {
                        return "Draw";
                    }
                    else if (opponent == "scissors")
                    {
                        return "Lost";
                    }
                    else if (opponent == "rock")
                    {
                        return "Win";
                    }
                    else
                    {
                        return "The opponent played an invalid hand";
                    }
                }
                else if (player == "scissors")
                {
                    if (opponent == "paper")
                    {
                        return "Win";
                    }
                    else if (opponent == "scissors")
                    {
                        return "Draw";
                    }
                    else if (opponent == "rock")
                    {
                        return "Lost";
                    }
                    else
                    {
                        return "The opponent played an invalid hand";
                    }
                }
                else
                {
                    return "The player played an invalid hand";
                }
            }
        }

        private static void HigherLower()
        {

            Random rnd = new Random();
            int max = 1;
            do
            {
                Console.Clear();
                Console.Write("what's the biggest number you wanna guess? ");

            } while (!int.TryParse(Console.ReadLine(), out max) || max <= 0);
            int number = rnd.Next(1, max + 1);
            int guess = 0;
            do
            {
                do
                {
                    Console.Write("take a guess: ");
                } while (!int.TryParse(Console.ReadLine(), out guess));

                if (number < guess)
                {
                    Console.WriteLine("the number is lower");
                }
                if (number > guess)
                {
                    Console.WriteLine("the number is higher");
                }
            } while (guess != number && guess != 0);
            if (guess == number)
            {
                Console.WriteLine($"good job the number was {number}");
            }
            else
            {
                Console.WriteLine($"better luck next time the number was {number} btw");
            }

            Console.ReadLine();

        }

        static public void Blackjack()
        {
            Deck deck = new Deck();
            int score = 0;
            deck.Shuffle();
            Console.Clear();
            Console.WriteLine("Welcome to blackjack please draw a card.");
            Console.ReadLine();
            while (score < 21 && deck.CountCards() > 0)
            {
                Dictionary<string, int> card = deck.drawCard();
                score += card.Last().Value;
                Console.WriteLine($"you drew {card.Last().Key} your score is {score}");
            }
            if (score > 21) { Console.WriteLine($"BUST!!! You went {score - 21} over 21"); }
            if (score == 21) { Console.WriteLine($"You win good job"); }
            if (deck.CountCards() <= 0) { Console.WriteLine($"the deck is empty sorry"); }

            Console.ReadLine();

        }
    }
}
