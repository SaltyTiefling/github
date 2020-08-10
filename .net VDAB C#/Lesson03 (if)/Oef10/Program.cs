using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Oef10
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            Dictionary<string, string> guildID = new Dictionary<string, string>();

            while (!(input.ToLower().Contains("goodbye")))
            {
                Console.WriteLine("Hallo, my name is Amanda what is your name?");
                input = Console.ReadLine();
                guildID.Add("name", input);
                Console.WriteLine($"Welcome to the guild, {guildID["name"]}. I notice you are new here would you like a guildID? (Y/N)");
                input = Console.ReadLine();
                if (input.ToLower() == "n")
                {
                    break;
                }
                Console.WriteLine("wat is je leeftijd?");
                input = Console.ReadLine();
                if (Convert.ToInt32(input) < 18)
                {
                    Console.WriteLine($"you're too young to join the guild come back in about {18 - Convert.ToInt32(input)} years");
                    break;
                }
                Console.WriteLine("what is your gender if I may ask?");
                input = Console.ReadLine();
                switch (input.ToLower())
                {
                    case "f":
                    case "girl":
                    case "woman":
                    case "gall":
                    case "dudette":
                        guildID.Add("gender", "♀");
                        break;
                    case "m":
                    case "male":
                    case "man":
                    case "guy":
                    case "dude":
                        guildID.Add("gender", "♂");
                        break;
                    default:
                        Console.WriteLine("i'll just write down \"Other\".");
                        guildID.Add("gender", "?");
                        break;
                }

                Console.Write("so tell me what is your prefered weapon? or do you rather use magic?");
                input = Console.ReadLine().ToLower();

                switch (input)
                {
                    case "sword":
                        Console.WriteLine("oh a student of the blade. *bows*");
                        break;
                    case "fists":
                        Console.WriteLine("a bare knuckle kinda guy I like it.");
                        break;
                    case "bow":
                        Console.WriteLine("May you aim be true.");
                        break;
                    case "axe":
                        Console.WriteLine("\"and my Axe\" amirite ");
                        break;
                    case "magic":
                        Console.WriteLine("ha, nerd");
                        break;
                    case "faith":
                        Console.WriteLine("well you got god now you just need Anime on your side");
                        break;
                    case "banana":
                        var link = new ProcessStartInfo("chrome.exe");
                        link.Arguments = "https://www.youtube.com/watch?v=yModCU1OVHY";
                        Process.Start(link);
                        break;
                    default:
                        Console.WriteLine($"never heard of using {input}, but no worries i'll put that down");
                        break;
                }
                guildID.Add("weapon", input);
                Console.WriteLine("oke just one more thing. what level do you think you are?");
                input = Console.ReadLine();
                guildID.Add("level", "beginner");

                Console.WriteLine("your guildID looks like this");
                foreach (var item in guildID)
                {
                    Console.WriteLine($"{item.Key}: {item.Value}");
                }

                Console.Write("is dit correct? (Y/N)");
                if (Console.ReadLine().ToLower() == "y")
                {
                    break;
                }
                else
                {
                    guildID.Clear();
                }
            } 
            Console.WriteLine("oke there you go, cya!");

            Console.ReadLine();
        }
    }
}
