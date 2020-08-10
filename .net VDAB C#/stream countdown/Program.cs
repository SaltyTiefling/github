using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace stream_countdown
{
    class Program
    {
        static void Main(string[] args)
        {

            DateTime verlossing = new DateTime(
                DateTime.Now.Year,
                DateTime.Now.Month,
                inputCheckInt("Day"),
                inputCheckInt("Hour"),
                inputCheckInt("Minutes"),
                0);


            const string bestandsnaam = "countdownDocument.txt";
            if (!File.Exists(bestandsnaam))
            {
                File.Create(bestandsnaam).Dispose();
            }

            TimeSpan countdown = verlossing - DateTime.Now;
            Console.Clear();
            Console.CursorVisible = false;
            do
            {
                File.WriteAllText(bestandsnaam, string.Empty);
                using (StreamWriter writer = new StreamWriter(bestandsnaam))
                {
                    writer.Write((countdown.Hours < 10) ? $"0{countdown.Hours}:" : $"{countdown.Hours}:");
                    writer.Write((countdown.Minutes < 10) ? $"0{countdown.Minutes}:" : $"{countdown.Minutes}:");
                    writer.WriteLine((countdown.Seconds < 10) ? $"0{countdown.Seconds}" : $"{countdown.Seconds}");
                }

                Console.SetCursorPosition(0,0);
                Console.Write((countdown.Hours < 10) ? $"0{countdown.Hours}:" : $"{countdown.Hours}:");
                Console.Write((countdown.Minutes < 10) ? $"0{countdown.Minutes}:" : $"{countdown.Minutes}:");
                Console.WriteLine((countdown.Seconds < 10) ? $"0{countdown.Seconds}" : $"{countdown.Seconds}");

                Thread.Sleep(1000);
                countdown = verlossing - DateTime.Now;
            } while (countdown >= TimeSpan.Zero);
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
