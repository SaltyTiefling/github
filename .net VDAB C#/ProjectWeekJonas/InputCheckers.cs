using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWeekJonas
{
    public class InputCheckers
    {
        static public int IntAsk(string vraag)
        {
            int output = 0;
            bool inputCorrect = false;
            do
            {
                try
                {
                    Console.Write($"{vraag}: ");
                    output = Convert.ToInt32(Console.ReadLine());
                    inputCorrect = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!inputCorrect);
            return output;

        }
        static public int IntAsk(string vraag, int min, int max)
        {
            int output = -1;
            bool inputCorrect = false;
            do
            {
                output = IntAsk(vraag); ;
                try
                {
                    if (output > max || output < min) { throw new ArgumentOutOfRangeException($"geef een getal in tussen {min}-{max}",new ArgumentOutOfRangeException()); }
                    inputCorrect = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!inputCorrect);

            return output;
        }
        static public int Int(string input)
        {
            int output = 0;
            bool inputCorrect = false;
            do
            {
                try
                {
                    output = Convert.ToInt32(input);
                    inputCorrect = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!inputCorrect);
            return output;

        }
        static public int Int(string input, int min, int max)
        {
            int output = -1;
            bool inputCorrect = false;
            do
            {
                output = Int(input);
                try
                {
                    if (output > max || output < min) { throw new ArgumentOutOfRangeException($"geef een getal in tussen {min}-{max}", new ArgumentOutOfRangeException()); }
                    inputCorrect = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (!inputCorrect);

            return output;
        }
    }
}
