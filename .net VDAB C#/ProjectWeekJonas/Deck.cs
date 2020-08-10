using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectWeekJonas
{
    class Deck
    {
        public Dictionary<string, int> cardlist = new Dictionary<string, int>();
        char[] suits = { (char)3, (char)4, (char)5, (char)6}; // {♥,♦,♣,♠}
        char[] specialCards = { 'J', 'Q', 'K' };

        public Deck()
        {
            foreach (var suit in suits)
            {
                cardlist.Add($"A{suit}", 11);
                for (int i = 2; i <= 10; i++)
                {
                    cardlist.Add($"{i}{suit}", i);
                }
                foreach (var special in specialCards)
                {
                    cardlist.Add($"{special}{suit}", 10);
                }
            }
        }

        public void Shuffle()
        {
            Console.WriteLine("de deck is geshuffled");
            Random rand = new Random();
            cardlist = cardlist.OrderBy(x => rand.Next()).ToDictionary(item => item.Key, item => item.Value);
        }
        public Dictionary<string, int> drawCard()
        {
            Dictionary<string, int> output = new Dictionary<string, int>();
            output.Add(cardlist.Last().Key, cardlist.Last().Value);
            cardlist.Remove(output.Keys.Last());
            return output;
        }

        public int CountCards()
        {
            return cardlist.Count();
        }
        public Dictionary<string, int> GetDecklist()
        {
            return cardlist;
        }
    }


}
