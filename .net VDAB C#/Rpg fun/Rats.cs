using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_fun
{
    class Rats
    {
        readonly Random dice = new Random();
        int hp;

        public Rats()
        {
            this.hp = dice.Next(8) + 1 + 6;
        }

        public void DamageTaken(int dmg)
        {
            this.hp -= dmg;
        }
        public bool IsDead()
        {
            if (this.hp <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Attack(Character player)
        {

        }
    }
}
