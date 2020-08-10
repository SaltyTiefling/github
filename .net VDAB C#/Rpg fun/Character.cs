using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.Remoting.Activation;
using System.Text;
using System.Threading.Tasks;

namespace Rpg_fun
{
    public class Character
    {
        string name;
        int age;
        string gender;
        double level;
        private Job chosenJob;

        public Character()
        {
        }

        public Character(string name, int age, string gender, double level)
        {
            this.name = name;
            this.age = age;
            this.gender = gender;
            this.level = level;
        }
        public void SetName(string name) { this.name = name; }
        public string GetName() { return this.name; }
        public void SetAge(int age) { this.age = age; }
        public int Getage() { return this.age; }
        public void SetGender(string gender) { this.gender = gender; }
        public string GetGender() { return this.gender; }
        public void SetLevel(double level) { this.level = level; }
        public double GetLevel() { return this.level; }


        public void SetJob() {
            this.chosenJob = new Job("Commoner", 8, 5);
        }
        public void SetJob(string jobName, int hpDice, int damageMod)
        {
            this.chosenJob = new Job(jobName, hpDice,damageMod);
        }
        
    }
}
