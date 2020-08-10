using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oef01
{
    class Notitie
    {
        DateTime dateAndTime = DateTime.Now;
        public string opschrift;

        public Notitie(string opschrift)
        {
            this.opschrift = opschrift;
        }
        public void Bekijk()
        {
            Console.WriteLine($"{dateAndTime}: \"{opschrift}\"");
        }

    }
}
