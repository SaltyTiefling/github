using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Oef04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Jaar: ");
            int jaar = Convert.ToInt32(Console.ReadLine());
            switch (jaar)
            {
                case 1302:
                    Console.WriteLine($"In {jaar} was de guldensporenslag.");
                    break;

                case 1492:
                    Console.WriteLine($"On August 3, {jaar}, Columbus set sail from Palos, Spain, with three small ships, the Santa Maria, the Pinta, and the Nina. ... Later that month, Columbus sighted Cuba, which he thought was mainland China, and in December the expedition landed on Hispaniola, which Columbus thought might be Japan.");
                    break;

                case 1830:
                    Console.WriteLine($"On May 30, {jaar}: The Indian Removal Act was signed into law by President Andrew Jackson. The law led to the relocation of Native Americans which became known as the \"Trail of Tears.\" June 26, {jaar}: King George IV of England died and William IV ascended to the throne");
                    break;

                case 1914:
                    Console.WriteLine($"On June 28, {jaar}, in an event that is widely regarded as sparking the outbreak of World War I, Archduke Franz Ferdinand, heir to the Austro-Hungarian empire, was shot to death with his wife by Bosnian Serb Gavrilo Princip in Sarajevo, Bosnia.");
                    break;

                case 1918:
                    Console.WriteLine($"The {jaar} influenza pandemic was the most severe pandemic in recent history. It was caused by an H1N1 virus with genes of avian origin");
                    break;

                case 1939:
                    Console.WriteLine($"{jaar}–1941. The Holocaust took place in the broader context of World War II. On September 1, {jaar}, Germany invaded Poland. Over the next year, Nazi Germany and its allies conquered much of Europe");
                    break;

                case 1945:
                    Console.WriteLine($"What happened in {jaar} Major News Stories include USS Indianapolis is sunk by Japanese Submarine, War In Europe Ends May 7th ( V-E Day ), Adolf Hitler and his wife of one day, Eva Braun, commit suicide.");
                    break;

                case 2001:
                    Console.WriteLine($"On {jaar} al-Qaeda Terrorists attack the United States using hijacked passenger aircraft to bring down the Twin Towers in New York and crashing an aircraft into the Pentagon in Arlington County, Virginia leaving nearly 3,000 people dead. the attacks become known simply as 911 due to the date of the attack September 11th.");
                    break;

                case 2020:
                    Console.WriteLine($"In {jaar} had Ken het genoegen om jonas in te nemen als student");
                    break;

                default:
                    Console.WriteLine($"in {jaar} is er niets interessant gebeurd");
                    break;
            }
            Console.ReadLine();
        }
    }
}
