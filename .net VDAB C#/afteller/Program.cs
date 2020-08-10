using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace afteller
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime verlossing = new DateTime(
                inputCheckInt("Year"),
                inputCheckInt("Month"),
                inputCheckInt("Day"),
                inputCheckInt("Hour"),
                inputCheckInt("Minutes"),
                0);



            TimeSpan timeLeft = verlossing - DateTime.Now;
            Console.Clear();
            Console.WriteLine("Press ESC to stop");
            do
            {
                
                while (timeLeft.Milliseconds >= 0)
                {
                    Console.CursorVisible = false;
                    timeLeft = verlossing - DateTime.Now;
                    Console.WriteLine($"nog {timeLeft.Days} dagen, {timeLeft.Hours} uur, {timeLeft.Minutes} min {timeLeft.Seconds} sec, {timeLeft.Milliseconds} milli");
                    Console.SetCursorPosition(0, 1);
                }
                Console.SetCursorPosition(0, 1);
                Console.WriteLine("The time has come be free!!!!");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
        }

        static int inputCheckInt(string question)
        {
            string input;
            int result;
            do
            {
                Console.Write($"{question}: ");
                input = Console.ReadLine();
            } while (!int.TryParse(input, out result) && (result > 0 || question.ToLower() == "year"));
            return result;
        }
    }
}
