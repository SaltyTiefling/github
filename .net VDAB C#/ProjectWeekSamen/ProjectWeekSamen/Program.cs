using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ProjectWeekSamen
{
    class Program
    {
        //CTRL M+O
        //CTRL M+L
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                switch (SelectMenu("Toevoegen", "Bewerken", "Verwijderen", "Inloggen"))
                {

                    case 1:
                        GebruikerToevoegen();
                        break;
                    case 2:
                        GebruikerBewerken();
                        break;
                    case 3:
                        GebruikerVerwijderen();
                        break;
                    case 4:
                        SpelMenu(Inloggen());
                        break;
                    default:
                        DefaultErrorMessage();
                        break;
                }
            }
        }
        static void SpelMenu(string username)
        {
            if (username != "")
            {
                DateTime loginSinds = DateTime.Now;
                bool loggedIn = true;
                int saldo = 200;
                while (loggedIn)
                {
                    Console.Clear();
                    Console.WriteLine("Beste " + username + ". Het is " + DateTime.Now.ToString("dd/MM HH:mm:ss") + ".");
                    int aantalMinuten = (DateTime.Now - loginSinds).Minutes;
                    Console.WriteLine("Je bent al " + aantalMinuten.ToString() + " " + (aantalMinuten == 1 ? "minuut" : "minuten") + " online.");
                    Console.WriteLine("Jouw Saldo is $" + saldo + ".");
                    Console.ReadLine();

                    switch (SelectMenu("BlackJack", "Slot Machine", "Memory", "Uitloggen"))
                    {
                        case 1:
                            if (saldo >= 10)
                            {
                                saldo -= 10;
                                saldo = BlackJack(saldo);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Niet genoeg geld");
                                Console.ReadLine();
                            }
                            break;
                        case 2:
                            if (saldo >= 5)
                            {
                                saldo -= 5;
                                saldo = SlotMachine(saldo);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Niet genoeg geld");
                                Console.ReadLine();
                            }
                            break;
                        case 3:
                            if (saldo >= 20)
                            {
                                saldo -= 20;
                                saldo = Memory(saldo);
                            }
                            else
                            {
                                Console.Clear();
                                Console.WriteLine("Niet genoeg geld");
                                Console.ReadLine();
                            }
                            break;
                        case 4:
                            loggedIn = false;
                            break;
                        default:
                            DefaultErrorMessage();
                            break;
                    }
                }
            }
        }
        static int BlackJack(int saldo)
        {
            Console.Clear();
            List<int> deck = new List<int>();
            for (int i = 0; i < 52; i++)
            {
                deck.Add(i);
            }

            deck = Shuffle(deck);

            int wijzer = 0;
            int totaal = 0;
            int aces = 0;
            List<int> mijnHand = new List<int>();

            Console.Write("Je trekt een ");
            mijnHand.Add(VisualizeCard(deck[wijzer++]));
            Console.Write(" en een ");
            mijnHand.Add(VisualizeCard(deck[wijzer++]));
            Console.WriteLine(".");

            bool stop = false;

            while (!stop)
            {
                totaal = 0;
                aces = 0;
                Console.Write("Jouw hand: ");
                foreach (var item in mijnHand)
                {
                    if (ValueCard(item) == 11)
                        aces++;
                    totaal += ValueCard(item);
                    VisualizeCard(item);
                    Console.Write(' ');
                }

                for (int i = aces; i > 0; i--)
                {
                    if (totaal > 21)
                        totaal -= 10;
                }

                Console.WriteLine("voor een totaal van " + totaal + ".");
                Console.ReadLine();

                if (totaal == 21 && mijnHand.Count == 2)
                {
                    Console.WriteLine("Proficiat! Je wint $25!");
                    Console.ReadLine();
                    saldo += 25;
                    stop = true;
                }
                else if (totaal == 21)
                {
                    stop = true;
                }
                else if (totaal > 21)
                {
                    Console.WriteLine("Jammer! Je bent gecrashed!");
                    Console.ReadLine();
                    stop = true;
                }
                else if (SelectMenu("Trek een kaart bij", "Wait") == 1)
                {
                    Console.Clear();
                    Console.Write("Je trekt een ");
                    mijnHand.Add(VisualizeCard(deck[wijzer++]));
                    Console.Write(" bij.");
                    Console.WriteLine();
                }
                else
                {
                    stop = true;
                }
            }

            if (totaal <= 21 && !(mijnHand.Count <= 2 && totaal == 21))
            {
                List<int> dealerHand = new List<int>();
                int dealerTotaal = 0;
                int dealerAces = 0;

                Console.Write("De dealer trekt een ");
                dealerHand.Add(VisualizeCard(deck[wijzer++]));
                Console.Write(" en een ");
                dealerHand.Add(VisualizeCard(deck[wijzer++]));
                Console.WriteLine(".");

                while (dealerTotaal < 17)
                {
                    dealerTotaal = 0;

                    Console.Write("De dealer hand: ");
                    foreach (var item in dealerHand)
                    {
                        if (ValueCard(item) == 11)
                            dealerAces++;
                        dealerTotaal += ValueCard(item);
                        VisualizeCard(item);
                        Console.Write(' ');
                    }

                    for (int i = dealerAces; i > 0; i--)
                    {
                        if (dealerTotaal > 21)
                            dealerAces -= 10;
                    }

                    Console.WriteLine("voor een totaal van " + dealerTotaal + ".");
                    Console.ReadLine();

                    if (dealerTotaal < 17)
                    {
                        Console.Clear();
                        Console.Write("De dealer trekt een ");
                        dealerHand.Add(VisualizeCard(deck[wijzer++]));
                        Console.Write(" bij.");
                        Console.WriteLine();
                    }
                }


                Console.WriteLine("Jij hebt {0} en de dealer heeft {1}.", totaal, dealerTotaal);
                if (totaal == dealerTotaal)
                {
                    saldo += 10;
                    Console.WriteLine("Gelijk! Je krijgt je geld terug!");
                    Console.ReadLine();
                }
                else if (totaal > dealerTotaal || dealerTotaal > 21)
                {
                    saldo += 20;
                    Console.WriteLine("Gewonnen! Je verdient $20!");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Jammer. Verloren.");
                    Console.ReadLine();
                }
            }

            return saldo;
        }
        static int ValueCard(int getal)
        {
            switch (getal % 13)
            {
                case 1:
                    return 11;
                case 11:
                case 12:
                case 0:
                    return 10;
                default:
                    return getal % 13;
            }
        }
        static int VisualizeCard(int getal)
        {
            string kaart = "";

            switch (getal / 13)
            {
                case 0:
                    Console.ForegroundColor = ConsoleColor.Red;
                    kaart += "♥";
                    break;

                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    kaart += "♦";
                    break;

                case 2:
                    Console.ForegroundColor = ConsoleColor.White;
                    kaart += "♣";
                    break;

                case 3:
                    Console.ForegroundColor = ConsoleColor.White;
                    kaart += "♠";
                    break;
                default:
                    DefaultErrorMessage();
                    break;
            }

            switch (getal % 13)
            {
                case 1:
                    kaart += "A";
                    break;
                case 11:
                    kaart += "J";
                    break;
                case 12:
                    kaart += "Q";
                    break;
                case 0:
                    kaart += "K";
                    break;
                default:
                    kaart += getal % 13;
                    break;
            }

            Console.Write(kaart);
            Console.ResetColor();
            return getal;
        }
        static int SlotMachine(int saldo)
        {
            Console.Clear();
            Console.CursorVisible = false;
            string rotator = "☻☻☻☻☻♠♠♠♠♣♣♣♣♦♦♦♥♥♥AA7";

            List<char> row1 = new List<char>();
            List<char> row2 = new List<char>();
            List<char> row3 = new List<char>();

            foreach (var item in rotator)
            {
                row1.Add(item);
                row2.Add(item);
                row3.Add(item);
            }

            row1 = Shuffle(row1);
            System.Threading.Thread.Sleep(50);
            row2 = Shuffle(row2);
            System.Threading.Thread.Sleep(50);
            row3 = Shuffle(row3);

            int teller = 0;
            int duration = 50;

            while (teller < duration)
            {
                Console.SetCursorPosition(0, 0);

                if (teller < duration / 3)
                {
                    row1.Add(row1[0]);
                    row1.RemoveAt(0);
                }

                if (teller < duration / 3 * 2)
                {
                    row2.Add(row2[0]);
                    row2.RemoveAt(0);
                }

                row3.Add(row3[0]);
                row3.RemoveAt(0);

                for (int i = 0; i <= 2; i++)
                {
                    Console.Write(ColorSign('['));
                    Console.Write(ColorSign(row1[i]) + " ");
                    Console.Write(ColorSign(row2[i]) + " ");
                    Console.Write(ColorSign(row3[i]));
                    Console.WriteLine(ColorSign(']'));
                }
                System.Threading.Thread.Sleep(100 + Math.Max(0, 10 + teller - duration) * 100);
                teller++;
            }

            Console.CursorVisible = true;
            int winst = 0;

            if (row1[0] == row2[0] && row1[0] == row3[0])
                winst += ValueSign(row1[0]);
            if (row1[1] == row2[1] && row1[1] == row3[1])
                winst += ValueSign(row1[1]);
            if (row1[2] == row2[2] && row1[2] == row3[2])
                winst += ValueSign(row1[2]);
            if (row1[0] == row2[1] && row1[0] == row3[2])
                winst += ValueSign(row1[0]);
            if (row1[2] == row2[1] && row1[2] == row3[0])
                winst += ValueSign(row1[2]);

            if (winst > 0)
                Console.WriteLine("Je wint ${0}.", winst);
            else
                Console.WriteLine("Je wint niets!");
            Console.ReadLine();

            return saldo + winst;

        }
        static int ValueSign(char sign)
        {
            int winst = 0;

            switch (sign)
            {
                case '☻':
                    winst = 3;
                    break;
                case '♠':
                    winst = 5;
                    break;
                case '♣':
                    winst = 7;
                    break;
                case '♦':
                    winst = 10;
                    break;
                case '♥':
                    winst = 20;
                    break;
                case 'A':
                    winst = 50;
                    break;
                case '7':
                    winst = 100;
                    break;
            }

            return winst;
        }
        static char ColorSign(char sign)
        {
            switch (sign)
            {
                case '☻':
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                    break;
                case '♠':
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    break;
                case '♣':
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case '♦':
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case '♥':
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
                case 'A':
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    break;
                case '7':
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                default:
                    Console.ResetColor();
                    break;
            }

            return sign;
        }
        static int Memory(int saldo)
        {
            Console.Clear();

            List<char> kaarten = new List<char>();
            string kaartenString = "♥♥♦♦♣♣♠♠77";

            foreach (var item in kaartenString)
            {
                kaarten.Add(item);
            }

            kaarten = Shuffle(kaarten);

            Console.WriteLine(" 0   1   2   3   4   5   6   7   8   9");
            foreach (var item in kaarten)
            {
                Console.Write(ColorSign('['));
                Console.Write(ColorSign(item));
                Console.Write(ColorSign(']') + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Onthoud dit!");
            System.Threading.Thread.Sleep(5000);

            char[] geraden = new char[10];
            for (int i = 0; i < geraden.Length; i++)
            {
                geraden[i] = '?';
            }

            bool finished = false;
            while (!finished)
            {
                Console.Clear();
                Console.WriteLine(" 0   1   2   3   4   5   6   7   8   9");
                foreach (var item in geraden)
                {
                    Console.Write(ColorSign('['));
                    Console.Write(ColorSign(item));
                    Console.Write(ColorSign(']') + " ");
                }

                bool test = true;
                for (int i = 0; i < kaarten.Count; i++)
                {
                    if (kaarten[i] != geraden[i])
                        test = false;
                }

                Console.WriteLine();
                if (test)
                {
                    finished = true;
                    saldo += 30;
                    Console.WriteLine("Proficiat! Gewonnen!");
                    Console.ReadLine();
                }
                else
                {
                    int kaart1 = Convert.ToInt32(VraagInput("Kaart 1"));
                    int kaart2 = Convert.ToInt32(VraagInput("Kaart 2"));

                    if (kaarten[kaart1] == kaarten[kaart2])
                    {
                        geraden[kaart1] = kaarten[kaart1];
                        geraden[kaart2] = kaarten[kaart2];
                    }
                    else
                    {
                        finished = true;
                        Console.WriteLine("Dat is jammer genoeg fout!");
                        Console.ReadLine();
                    }
                }
            }

            return saldo;
        }
        static List<int> Shuffle(List<int> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                int value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return list;
        }
        static List<char> Shuffle(List<char> list)
        {
            Random rng = new Random();
            int n = list.Count;
            while (n > 1)
            {
                n--;
                int k = rng.Next(n + 1);
                char value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return list;
        }
        static int SelectMenu(params string[] menu)
        {
            Console.CursorVisible = false;
            Console.Clear();

            int selection = 1;
            bool selected = false;

            ConsoleColor selectionForeground = Console.BackgroundColor;
            ConsoleColor selectionBackground = Console.ForegroundColor;

            while (!selected)
            {
                int teller = 0;
                foreach (var item in menu)
                {
                    teller++;

                    if (selection == teller)
                    {
                        Console.ForegroundColor = selectionForeground;
                        Console.BackgroundColor = selectionBackground;
                    }

                    Console.WriteLine(teller + ": " + item);
                    Console.ResetColor();
                }

                //Google "C# console check key press"
                //https://stackoverflow.com/questions/5891538/listen-for-key-press-in-net-console-app
                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.UpArrow:
                        selection--;
                        break;
                    case ConsoleKey.DownArrow:
                        selection++;
                        break;
                    case ConsoleKey.Enter:
                        selected = true;
                        break;
                }

                selection = Math.Min(Math.Max(selection, 1), menu.Length);

                //Console.Clear();
                Console.SetCursorPosition(0, 0);
            }

            Console.Clear();
            Console.CursorVisible = true;
            return selection;
        }
        static void GebruikerToevoegen()
        {
            string naam = VraagNaam();
            string wachtwoord = VraagWachtwoord();

            using (StreamWriter writer = new StreamWriter("gegevens.txt", true))
            {
                writer.Write(naam + " ");
                writer.WriteLine(Encryptor(wachtwoord));
                Console.WriteLine("De gebruiker werd toegevoegd");
            }
            Console.ReadLine();
        }
        static void GebruikerBewerken()
        {
            string[] gebruikersList = GebruikersOphalen().ToArray();
            string gekozenUsername = gebruikersList[SelectMenu(gebruikersList) - 1];

            switch (SelectMenu(gekozenUsername + " zijn username aanpassen", gekozenUsername + " zijn wachtwoord aanpassen"))
            {
                case 1:
                    {
                        string nieuweNaam = VraagNaam();
                        List<string> gebruikers = AllesOphalen();

                        string lijn = gebruikers[gebruikers.FindIndex(ind => ind.Split(' ')[0].Equals(gekozenUsername))];
                        gebruikers[gebruikers.FindIndex(ind => ind.Split(' ')[0].Equals(gekozenUsername))] = ReplaceFirst(lijn, gekozenUsername, nieuweNaam);

                        using (StreamWriter writer = new StreamWriter("gegevens.txt"))
                        {
                            foreach (var item in gebruikers)
                            {
                                writer.WriteLine(item);
                            }
                        }

                        Console.WriteLine("Username aangepast");
                        Console.ReadLine();
                        //listOfStrings[listOfStrings.FindIndex(ind => ind.Equals("123"))] = "def";
                    }
                    break;

                case 2:
                    {
                        string nieuwWachtwoord = VraagWachtwoord();
                        List<string> gebruikers = AllesOphalen();

                        string lijn = gebruikers[gebruikers.FindIndex(ind => ind.Split(' ')[0].Equals(gekozenUsername))];
                        gebruikers[gebruikers.FindIndex(ind => ind.Split(' ')[0].Equals(gekozenUsername))] = lijn.Split(' ')[0] + " " + Encryptor(nieuwWachtwoord);

                        using (StreamWriter writer = new StreamWriter("gegevens.txt"))
                        {
                            foreach (var item in gebruikers)
                            {
                                writer.WriteLine(item);
                            }
                        }

                        Console.WriteLine("Wachtwoord aangepast");
                        Console.ReadLine();
                    }
                    break;

                default:
                    DefaultErrorMessage();
                    break;
            }
        }
        static void GebruikerVerwijderen()
        {
            string[] gebruikersList = GebruikersOphalen().ToArray();
            string gekozenUsername = gebruikersList[SelectMenu(gebruikersList) - 1];

            List<string> gebruikers = AllesOphalen();
            string lijn = gebruikers[gebruikers.FindIndex(ind => ind.Split(' ')[0].Equals(gekozenUsername))];
            gebruikers.Remove(lijn);

            using (StreamWriter writer = new StreamWriter("gegevens.txt"))
            {
                foreach (var item in gebruikers)
                {
                    writer.WriteLine(item);
                }
            }
        }
        static string Inloggen()
        {
            Console.Clear();
            string username = VraagInput("Username");
            string wachtwoord = VraagInput("Wachtwoord");

            List<string> gebruikers = AllesOphalen();

            bool loggedIn = false;

            foreach (var item in gebruikers)
            {
                if (item.Split(' ')[0].ToLower() == username.ToLower() && item.Split(' ')[1] == Encryptor(wachtwoord))
                {
                    loggedIn = true;
                    break;
                }
            }

            if (!loggedIn)
            {
                username = "";
                Console.WriteLine("Foute combinatie");
                Console.ReadLine();
            }

            return username;
        }
        static string VraagNaam()
        {
            string naam = null;
            bool passed = false;
            bool isUnique = true;

            do
            {
                Console.Clear();
                Console.WriteLine("Geef een username in.\nDe naam mag alleen letters en cijfers bevatten.\n");

                if (!isUnique)
                {
                    Console.WriteLine("Naam bestaat al");
                    passed = false;
                }

                if (passed)
                {
                    Console.WriteLine("Naam voldoet niet aan de regels");
                }
                passed = true;

                naam = VraagInput("Naam");

                List<string> checkUnique = GebruikersOphalen();

                isUnique = true;
                foreach (var item in checkUnique)
                {
                    if (naam.ToLower() == item.ToLower())
                    {
                        isUnique = false;
                    }
                }

            } while (!Regex.IsMatch(naam, @"^[a-zA-Z0-9]+$") || string.IsNullOrEmpty(naam) || !isUnique);

            return naam;
        }
        static string VraagWachtwoord()
        {
            string wachtwoord = null;
            bool passed = true;

            do
            {
                Console.Clear();
                Console.WriteLine("Kies een wachtwoord.\nHet wachtwoord moet minstens 1 hoofdletter, 1 kleine letter, 1 cijfer en 1 vreemd teken hebben.\nHet wachtwoord moet ook 8-20 tekens lang zijn.");

                if (!passed)
                {
                    Console.WriteLine("\nHet wachtwoord voldoet niet aan de regels.");
                    if (!wachtwoord.Any(char.IsUpper))
                        Console.WriteLine("Het bevat geen hoofdletters.");
                    if (!wachtwoord.Any(char.IsLower))
                        Console.WriteLine("Het bevat geen kleine letters.");
                    if (!wachtwoord.Any(char.IsDigit))
                        Console.WriteLine("Het bevat geen cijfers.");
                    if (wachtwoord.Length < 8)
                        Console.WriteLine("Het is te kort");
                    if (wachtwoord.Length > 20)
                        Console.WriteLine("Het is te lang");
                    if (Regex.IsMatch(wachtwoord, @"^[a-zA-Z0-9]+$"))
                        Console.WriteLine("Het bevat geen vreemd teken");
                }
                passed = false;

                wachtwoord = VraagInput("Wachtwoord");

            } while (!wachtwoord.Any(char.IsUpper)
            || !wachtwoord.Any(char.IsLower)
            || !wachtwoord.Any(char.IsDigit)
            || wachtwoord.Length < 8
            || wachtwoord.Length > 20
            || Regex.IsMatch(wachtwoord, @"^[a-zA-Z0-9]+$"));

            return wachtwoord;
        }
        static List<string> GebruikersOphalen()
        {
            List<string> gebruikers = new List<string>();
            using (StreamReader reader = new StreamReader("gegevens.txt"))
            {
                while (!reader.EndOfStream)
                {
                    gebruikers.Add(reader.ReadLine().Split(' ')[0]);
                }
            }

            return gebruikers;
        }
        static List<string> AllesOphalen()
        {
            List<string> data = new List<string>();
            using (StreamReader reader = new StreamReader("gegevens.txt"))
            {
                while (!reader.EndOfStream)
                {
                    data.Add(reader.ReadLine());
                }
            }
            return data;
        }
        static string VraagInput(string vraag)
        {
            Console.Write(vraag + ": ");
            return Console.ReadLine();
        }
        static string Encryptor(string wachtwoord)
        {
            string encrypted = "";
            foreach (var item in wachtwoord)
            {
                encrypted += 255 - item;
            }

            return encrypted;
        }
        static void DefaultErrorMessage()
        {
            Console.WriteLine("Er is iets fout gegaan...");
            Console.WriteLine("Neem contact op met de ontwikkelaar als je dit bericht opnieuw ziet.");
            Console.ReadLine();
        }
        static string ReplaceFirst(string text, string search, string replace)
        {
            int pos = text.IndexOf(search);
            if (pos < 0)
            {
                return text;
            }
            return text.Substring(0, pos) + replace + text.Substring(pos + search.Length);
        }
    }
}
