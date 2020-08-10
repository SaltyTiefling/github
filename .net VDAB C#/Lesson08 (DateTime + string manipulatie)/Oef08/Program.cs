using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef08
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime datum = DateTime.Now;
            bool inputCorrect = false;

            Console.WriteLine("geef uw geboortedatum in:");
            do
            {
                try
                {
                    datum = new DateTime(
                        inputCheckInt("Year"),
                        inputCheckInt("Month"),
                        inputCheckInt("Day"),
                        inputCheckInt("Hour"),
                        inputCheckInt("Minutes"),
                        0);
                    inputCorrect = true;

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    inputCorrect = false;
                }
            } while (!inputCorrect);

            TimeSpan timeLeft = datum - DateTime.Now;
            Console.Clear();
            Console.WriteLine("Press ESC to stop");
            do
            {

                while (timeLeft.Milliseconds >= 0)
                {
                    Console.CursorVisible = false;
                    timeLeft = datum - DateTime.Now;
                    Console.WriteLine($"nog {timeLeft.Days} dagen, {timeLeft.Hours} uur, {timeLeft.Minutes} min {timeLeft.Seconds} sec, {timeLeft.Milliseconds} milli");
                    Console.SetCursorPosition(0, 1);
                }
                Console.SetCursorPosition(0, 1);
                Console.WriteLine("The time has come be free!!!!");
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape);
            Console.ReadLine();
        }
        static int inputCheckInt(string question)
        {
            int result = 0;
            bool inputCorrect = false;

            do
            {
                try
                {
                    Console.Write($"{question}: ");
                    result = Convert.ToInt32(Console.ReadLine());
                    inputCorrect = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    Console.ReadLine();
                }
            } while (!inputCorrect);
            return result;
        }
    }
}

