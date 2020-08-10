using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ProjectWeekJonas
{
    class Blackjack
    {
           static List<Dictionary<string, int>> playerHand = new List<Dictionary<string, int>>();
           static List<Dictionary<string, int>> dealerHand = new List<Dictionary<string, int>>();
        internal static User Play(User player)
        {
            playerHand.Clear();
            dealerHand.Clear();

            Deck deck = new Deck();
            Console.Clear();
            deck.Shuffle();
            Console.WriteLine("de dealer kijkt je in de ogen en neemt $10");
            player.LoseMoney(10);
            Console.WriteLine($"Je hebt nog ${player.getMoney()}");
            if (player.broke()) Console.WriteLine("Je mag nog spelen maar als je niet wint is her over.");

            playerHand.Add(deck.drawCard());
            playerHand.Add(deck.drawCard());

            dealerHand.Add(deck.drawCard());


            Console.ReadLine();

            bool playing = true;
            while (playing && CountHand(playerHand) < 21)
            {
                PrintHands();
                bool inputCorrect = false;
                do
                {
                    Console.Write("wil je een kaart \"trekken\" of \"stoppen\"? ");
                    string input = Console.ReadLine().ToLower();
                    switch (input)
                    {
                        case "trekken":
                            playerHand.Add(deck.drawCard());
                            inputCorrect = true;
                            break;
                        case "stoppen":
                            playing = false;
                            inputCorrect = true;
                            break;
                        default:
                            Console.WriteLine("give valid input");
                            break;
                    }
                } while (!inputCorrect);
            }
            PrintHands();
            playing = true;
            if (CountHand(playerHand) == 21 && playerHand.Count() <= 2) { player.Payout(25); Console.WriteLine("!21! je wint $25"); return player; }
            if (CountHand(playerHand) > 21) { Console.WriteLine("BUST! Sorry volgende keer beter!"); return player; }

            dealerHand.Add(deck.drawCard());

            while (playing && CountHand(dealerHand) < 17)
            {
                PrintHands();
                Console.ReadLine();
                dealerHand.Add(deck.drawCard());
            }
            PrintHands();

            if (CountHand(dealerHand) > 21) { player.Payout(10); Console.WriteLine("dealer busted! Je wint $10"); return player; }
            else if (CountHand(playerHand) == CountHand(dealerHand)) { player.Payout(10); Console.WriteLine("Draw~ je krijgt je $10 terug"); return player; }
            else if (CountHand(playerHand) > CountHand(dealerHand)) { player.Payout(20); Console.WriteLine("!Jackpot! je wint $20"); return player; }
            else { Console.WriteLine("het huis wint! Sorry volgende keer beter"); return player; }
        }

        private static string stringCards(List<Dictionary<string, int>> hand)
        {
            string start = "\n";
            string mid = "";
            string end = "";

            foreach (var card in hand)
            {
                int length = card.First().Key.Length;
                string lines = "";

                for (int i = 0; i < length; i++)
                {
                    lines += "─";
                }

                start += $"┌{lines}┐ ";
                mid += $"│{card.First().Key}│ ";
                end += $"└{lines}┘ ";
            }

            return ($"{start}\n{mid}\n{end}");
        }

        private static void PrintHands()
        {
            Console.Clear();
            Console.WriteLine($"jouw hand: {stringCards(playerHand)}");
            Console.WriteLine($"totaal: {CountHand(playerHand)}");

            Console.WriteLine($"dealer's hand: {stringCards(dealerHand)}");
            Console.WriteLine($"totaal: {CountHand(dealerHand)}");
        }



        private static int CountHand(List<Dictionary<string, int>> hand)
        {
            int output = 0;
            int countA = 0;
            foreach (var card in hand)
            {
                output += card.First().Value;
                if (card.First().Key.Substring(0, 1) == "A") countA++;
            }

            while (output > 21 && countA > 0)
            {
                output -= 10;
                countA--;
            }

            return output;
        }
    }
}
