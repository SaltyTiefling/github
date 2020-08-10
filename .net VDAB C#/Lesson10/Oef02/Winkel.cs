using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Oef02
{
    class Winkel
    {
        public string naam { get; set; }
        string specialisatie;
        public List<Product> productenLijst = new List<Product>();
        List<Product> winkelkarretje = new List<Product>();
        public Winkel()
        {
            this.naam = "testWinkel";
            this.specialisatie = "testSpecialisatie";
            productenLijst.Add(new Product("Aardappel", "dat ding uit de grond", 0.50, 2000));
            productenLijst.Add(new Product("Nintendo Switch", "nintendo handheld console", 400.99, 1));
            productenLijst.Add(new Product("Raam", "om uit te kijken", 150, 15));
            productenLijst.Add(new Product("Microfoon", "hey is een blue Yeti", 100, 2));
            productenLijst.Add(new Product("Monitor", "voor te zien wat je PC doet", 135.45, 3));
        }
        public Winkel(string naam, string specialisatie, List<Product> producten)
        {
            this.naam = naam;
            this.specialisatie = specialisatie;
            productenLijst = producten;
        }
        public void steekInWinkelkarretje(Product product)
        {
            if (product.stock > 0)
            {
                winkelkarretje.Add(product);
                product.stock--;
            }
            else
            {
                Console.WriteLine($"er zijn geen {product.naam} meer in de winkel");
            }
        }
        public void Betalen()
        {
            double prijs = 0;
            foreach (Product product in winkelkarretje)
            {
                prijs += product.prijs;
            }
            winkelkarretje.Clear();
            Console.WriteLine($"alles samen kost {prijs}");
        }
        public void printWinkelKar()
        {
            foreach (var product in winkelkarretje)
            {
                product.Bekijk();
            }
        }
        public List<string> PrintProducten()
        {
            List<string> producten = new List<string>();
            foreach (var product in productenLijst)
            {
                producten.Add($"{product.naam} \"{product.beschrijving}\" we hebben er nog {product.stock}");
            }
            return producten;
        }
    }

}
