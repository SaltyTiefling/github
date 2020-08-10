using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef01
{
    class Notitieboekje
    {
        bool bewerkbaar = true;
        public string eigenaar { get; set; }
        public string titel { get; set; }
        public string kleur { get; set; }
        public List<Notitie> notities { get; set; }

        public Notitieboekje(string eigenaar, string titel, string kleur)
        {
            this.eigenaar = eigenaar;
            this.titel = titel;
            this.kleur = kleur;
            notities = new List<Notitie>();
        }

        public void Bijschrijven(string notitie)
        {
            if (bewerkbaar)
            {
                Notitie newNotitie = new Notitie(notitie);
                notities.Add(newNotitie);
            }
            else
            {
                Console.WriteLine("dit notietieboekje is al gelamineerd, je kan niet Bijschrijven");
            }
        }
        public void Uitscheuren(Notitie teVerwijderenNotitie)
        {
            if (bewerkbaar)
            {
                notities.Remove(teVerwijderenNotitie);
            }
            else
            {
                Console.WriteLine("dit notietieboekje is al gelamineerd, je kan niet Uitscheuren");
            }
        }
        public void BekijkNotitie(int index)
        {
            notities[index - 1].Bekijk();

        }
        public void BekijkNotities()
        {
            foreach (var notitie in notities)
            {
                notitie.Bekijk();
            }
        }
        public void BekijkEigenschappen()
        {
            Console.WriteLine($"Dit is {eigenaar} zijn {kleur} notitieboekje. De titel is \"{titel}\"." +
                $" In dit boekje zitten op dit moment {notities.Count()} notities");
        }
        public void Lamineren()
        {
            bewerkbaar = false;
        }

    }
}
