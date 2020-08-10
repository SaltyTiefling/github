using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_fun
{
    class Job {
        private string jobName;
        private int hpDice;
        private int damageMod;

        public Job(string jobName, int hpDice, int damageMod)
        {
            this.jobName = jobName;
            this.hpDice = hpDice;
            this.damageMod = damageMod;

        }
    }
}
