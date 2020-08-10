using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reeks2_Oef14
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "ACCOUNT";
            string pass = "LOL123";
            bool loginCorrect = false;
            bool passCorrect = false;
            do
            {
                loginCorrect = false;
                passCorrect = false;

                Console.Write("login:     ");
                if (Console.ReadLine() == login) loginCorrect = true;
                Console.Write("passwoord: ");
                if (Console.ReadLine() == pass) passCorrect = true;
            } while (!passCorrect || !loginCorrect);
        }
    }
}
