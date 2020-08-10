using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef02
{
    class Product
    {
        public string naam;
        public string beschrijving;
        public double prijs;
        public int stock;

        public Product(string naam, string beschrijving, double prijs, int stock)
        {
            this.naam = naam;
            this.beschrijving = beschrijving;
            this.prijs = prijs;
            this.stock = stock;
        }
        public void Bekijk()
        {
            Console.WriteLine($"{naam} \"{beschrijving}\" we hebben er nog {stock}");
        }
        public void addstock()
        {
            stock++;
        }
        public void addstock(int amountOfStockAdded)
        {
            stock+= amountOfStockAdded;
        }

    }
}
