using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Schema;

namespace ProjectWeekJonas
{
    public class Encryptor
    {
        public static string Encrypt(string text)
        {
            return Encrypt(text, false);
        }
        public static string Decrypt(string text)
        {
            return Encrypt(text, true);
        }

        public static string Encrypt(string text, bool decrypt)
        {
            List<char> incriptionlist = new List<char>();

            for (int i = Convert.ToInt32(' '); i <= Convert.ToInt32('~'); i++)
            {
                incriptionlist.Add(Convert.ToChar(i));
            }

            string output = "";

            foreach (var character in text)
            {
                int characterIndex = incriptionlist.IndexOf(character);
                int newcharacterindex = 0;

                if (decrypt)
                {
                    if (characterIndex - 10 < 0)
                    {
                        newcharacterindex = incriptionlist.Count() + (characterIndex-10) ;
                    } else
                    {
                        newcharacterindex = characterIndex - 10;
                    }
                }
                else
                {
                    newcharacterindex = (characterIndex + 10) % incriptionlist.Count();
                }
                output += incriptionlist[newcharacterindex];


            }
            return output;
        }

    }
}
