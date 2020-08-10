using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Media;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_fun
{
    class Display
    {
        static void Main(string[] args)
        {
            Character player = new Character();
            CharacterCreation(player);
            Quests.IntroQuest(player);
        }

        static void CharacterCreation(Character player)
        {
            string input;
            Console.WriteLine("hello adventurer please fill in your charactersheet before starting ^-^");

            Console.Write("what is your name?  ");
            player.SetName(Console.ReadLine());
            Console.Clear();
            Console.Write("how old are you?");

            input = Console.ReadLine();
            int age;
            while (!int.TryParse(input, out age))
            {
                Console.WriteLine("please, give a real number");
                input = Console.ReadLine();
            }
            if (age < 18)
            {
                Console.WriteLine($"sorry but you are still too young to go on an adventure please come back in {18 - age} years");
                Console.ReadLine();
                Environment.Exit(0);
            }
            player.SetAge(age);
            Console.Clear();

            Console.Write("what is you gender?");
            switch (Console.ReadLine().ToLower())
            {
                case "f":
                case "girl":
                case "woman":
                case "gall":
                case "dudette":
                    player.SetGender("man");
                    break;
                case "m":
                case "male":
                case "man":
                case "guy":
                case "dude":
                    player.SetGender("woman");
                    break;
                default:
                    Console.WriteLine("i'll just write down \"Other\".");
                    player.SetGender("Other");
                    break;
            }
            Console.Clear();
            if (CreatjobAsk())
            {
                Jobmaker(player);
            }
            else
            {
                player.SetJob();
            };
            Console.Clear();

            bool CreatjobAsk()
        {
            Console.Write("Do you wanna create your own Job (Y/N)? (if not you're a commoner)");
            switch (Console.ReadLine().ToLower())
            {
                case "y":
                case "yes":
                case "yup":
                    return true;
                case "n":
                case "no":
                case "nope":
                    return false;

                default:
                    return CreatjobAsk();
            }

        }
        }

        static void Jobmaker(Character player)
        {
            Console.Clear();
            Console.Write("welcome to the jobmaker please choose your jobname: ");
            string jobname = Console.ReadLine();
            Console.Write("What dice do you wanna use to determain hp?:        1d");
            string input = Console.ReadLine();
            int hpDice;
            while (!int.TryParse(input, out hpDice))
            {
                Console.WriteLine("please, give a real number");
                Console.Write("What dice do you wanna use to determain hp?:        1d");
                input = Console.ReadLine();
            }

            Console.Write("What is your damage modifier?:                      ");
            
            int damageMod;
            while (!int.TryParse(input, out damageMod))
            {
                Console.WriteLine("please, give a real number");
                Console.Write("What is your damage modifier?:                      ");
                input = Console.ReadLine();
            }
            player.SetJob(jobname, hpDice, damageMod);
        }


    }

}
