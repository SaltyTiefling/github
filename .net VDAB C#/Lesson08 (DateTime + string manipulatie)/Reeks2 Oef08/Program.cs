using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reeks2_Oef08
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, int> counter= new Dictionary<char, int>();
            Console.Write("geef een zin in: ");
            string input = Console.ReadLine();

            foreach (var letter in input)
            {
                if (counter.ContainsKey(letter))
                {
                    counter[letter]++;
                }
                else
                {
                    counter.Add(letter, 1);
                }
            }

            Console.WriteLine($"{counter.Aggregate((l, r) => l.Value > r.Value ? l : r).Key} komt " +
                $"{counter.Aggregate((l, r) => l.Value > r.Value ? l : r).Value} keer voor");
            Console.ReadLine();
        }
    }
}
