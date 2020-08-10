using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ProjectWeekJonas
{
    class User
    {
        string name;
        double money;
        DateTime LoggedIn;

        public User(string name)
        {
            this.name = name;
            this.money = 200;
            this.LoggedIn = DateTime.Now;
        }
        public void LoseMoney(double loss)
        {
            money -= loss;
        }
        public void Payout(double winnings)
        {
            money += winnings;
        }

        public bool broke()
        {
            if (money <=0)
            {
                return true;
            }
            return false;
        }
        public double getMoney()
        {
            return this.money;
        }

        public string getName()
        {
            return this.name;
        }
        public string TimePlayed()
        {
            TimeSpan timePlayed = DateTime.Now - LoggedIn;
            return $"{timePlayed.Hours} uur {timePlayed.Minutes} min {timePlayed.Seconds} sec";
        }
    }
}
