using System;
using System.Collections.Generic;
using System.IO;
using System.Text;



namespace ProjectWeekJonas
{

    class Program
    {
        const string userfileName = "users.txt";
        static User player = new User("test");
        static bool running = true;
        static bool loggedIn = true;
        static void Main(string[] args)
        {
            while (running)
            {
                loggedIn = false;
                AccountSystem();
                while (loggedIn && !player.broke())
                {
                    ConsoleKey keyboard;
                    int cursorspot = 2;
                    Console.Clear();
                    Console.WriteLine($"hallo {player.getName()} je hebt nog ${player.getMoney()} en speelt al {player.TimePlayed()}");
                    int choice;
                    Console.WriteLine("please kies één:");
                    Console.WriteLine(" 1.Blackjack");
                    Console.WriteLine(" 2.Slot machine");
                    Console.WriteLine(" 3.Memory");
                    Console.WriteLine(" 4.Uitloggen");

                    Console.SetCursorPosition(0, 2);
                    do
                    {
                        keyboard = Console.ReadKey().Key;
                        if (keyboard == ConsoleKey.DownArrow) cursorspot++;
                        if (keyboard == ConsoleKey.UpArrow) cursorspot--;

                        if (cursorspot < 2) cursorspot = 5;
                        if (cursorspot > 5) cursorspot = 2;
                        Console.SetCursorPosition(0, cursorspot);
                    } while (keyboard != ConsoleKey.Enter);
                    switch (cursorspot-1)
                    {
                        case 1:
                            Blackjack.Play(player);
                            break;
                        case 2:
                            Slots.Play(player);
                            break;
                        case 3:
                            Memory.Play(player);
                            break;
                        case 4:
                            loggedIn = false;
                            break;
                        default:
                            Console.WriteLine("hoe heb je dit zelfs ingevuld?");
                            break;
                    }
                    Console.ReadLine();
                }
            }
            Console.WriteLine("☺ Thanks for playing ☺");
        }

        private static bool AccountSystem()
        {
            if (!File.Exists(userfileName)) File.Create(userfileName).Dispose();
            Console.SetCursorPosition(0, 1);
            int cursorspot = 1;
            ConsoleKey keyboard;
            Console.Clear();
            Console.WriteLine("please choose one:");
            Console.WriteLine(" 1.Gebruiker toevoegen");
            Console.WriteLine(" 2.Gebruiker bewerken");
            Console.WriteLine(" 3.Gebruiker verwijderen");
            Console.WriteLine(" 4.Inloggen");
            Console.WriteLine(" 5.Close");
            Console.SetCursorPosition(0, 1);
            do
            {
                keyboard = Console.ReadKey().Key;
                if (keyboard == ConsoleKey.DownArrow) cursorspot++;
                if (keyboard == ConsoleKey.UpArrow) cursorspot--;

                if (cursorspot < 1) cursorspot = 5;
                if (cursorspot > 5) cursorspot = 1;
                Console.SetCursorPosition(0, cursorspot);
            } while (keyboard != ConsoleKey.Enter);
            string login;
            Console.Clear();
            switch (cursorspot)
            {
                case 1:
                    Console.Write("Login: ");
                    login = Console.ReadLine();
                    AddUser(login);
                    break;
                case 2:
                    Console.Write("Login: ");
                    login = Console.ReadLine();
                    ChangeUser(login);
                    break;
                case 3:
                    Console.Write("Login: ");
                    login = Console.ReadLine();
                    DeleteUser(login);
                    Console.ReadLine();
                    break;
                case 4:
                    LogIn();
                    Console.ReadLine();
                    break;
                case 5:
                    running = false;
                    break;
                default:
                    Console.WriteLine("hoe heb je dit zelfs ingevuld?");
                    break;
            }
            return loggedIn;
        }

        private static void LogIn()
        {
            Dictionary<string, string> users = GetUsers();
            Console.Write("Login: ");
            string name = Console.ReadLine();

            if (users.ContainsKey(name))
            {
                Console.Write("Wachtwoord: ");
                string password = Console.ReadLine();
                if (Encryptor.Decrypt(users[name]) == password)
                {
                    player = new User(name);
                    loggedIn = true;
                }
                else
                {
                    Console.WriteLine($"wrong password");
                }
            }
            else
            {
                Console.WriteLine($"user {name} doesn't exist");
            }
        }

        private static Dictionary<string, string> GetUsers()
        {
            Dictionary<string, string> userfiles = new Dictionary<string, string>();

            using (StreamReader reader = new StreamReader(userfileName))
            {
                while (reader.EndOfStream.Equals(false))
                {
                    userfiles.Add(reader.ReadLine(), reader.ReadLine());
                }
            }
            return userfiles;
        }

        private static void UpdateUsers(Dictionary<string, string> users)
        {

            File.WriteAllText(userfileName, string.Empty);
            foreach (var user in users)
            {
                WriteAwayLogin(user.Key, user.Value);
            }

        }

        private static void DeleteUser(string login)
        {
            Dictionary<string, string> userList = GetUsers();

            if (userList.ContainsKey(login))
            {
                userList.Remove(login);
                UpdateUsers(userList);
            }
            else
            {
                Console.WriteLine("user does not exit");
            }
        }

        private static void ChangeUser(string login)
        {
            DeleteUser(login);
            AddUser(login);
        }

        private static void AddUser(string login)
        {

            if (GetUsers().ContainsKey(login))
            {
                Console.WriteLine("login bestaat al");
            }
            else
            {
                WriteAwayLogin(login, NewPassword());
                Console.WriteLine("nieuwe login aangemaakt");
            }

            Console.ReadLine();
        }

        private static string NewPassword()
        {
            string output = "";
            bool running = true;

            do
            {
                int lowerLetters = 0;
                int upperLetters = 0;
                int numbers = 0;
                int specialCharacters = 0;

                Console.Write("nieuw Wachtwoord: ");
                output = Console.ReadLine();

                foreach (var character in output)
                {
                    if (char.ToLower(character) >= 97 && char.ToLower(character) <= 122)
                    {
                        if (character == char.ToLower(character)) { lowerLetters++; }
                        if (character == char.ToUpper(character)) { upperLetters++; }
                    }
                    else if (character >= 48 && character <= 57)
                    {
                        numbers++;
                    }
                    else
                    {
                        specialCharacters++;
                    }
                }

                try
                {
                    if (upperLetters < 1)
                    {
                        throw new ArgumentException("geef een wachtwoord in met minstens 1 hoofdletter");

                    }
                    if (lowerLetters < 1)
                    {
                        throw new ArgumentException("geef een wachtwoord in met minstens 1 kleine letter");
                    }
                    if (numbers < 1)
                    {
                        throw new ArgumentException("geef een wachtwoord in met minstens 1 cijfer");

                    }
                    if (specialCharacters < 1)
                    {
                        throw new ArgumentException("geef een wachtwoord in met minstens 1 vreemd teken");

                    }
                    if (output.Length < 8 || output.Length > 20)
                    {
                        throw new ArgumentException("geef een wachtwoord in tussen 8-20 characters lang");
                    }

                    running = false;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            } while (running);
            return Encryptor.Encrypt(output);
        }

        private static void WriteAwayLogin(string login, string password)
        {
            using (StreamWriter writer = File.AppendText(userfileName))
            {
                writer.WriteLine(login);
                writer.WriteLine(password);
            }
        }
    }
}
