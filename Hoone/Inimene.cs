using System;
using System.Collections.Generic;
using System.Text;

namespace Hoone
{
    public class Inimene
    {
        private string nimi;
        public Hoone hoone { get; set; }

        public Inimene(string nimi)
        {
            this.nimi = nimi;
        }

        public void NaitaInfo()
        {
            Console.WriteLine($"Mina olen inimene, minu nimi on {nimi}");
            Console.WriteLine("Hoone info:");
            hoone.NaitaInfo();
            Console.WriteLine("Ukse info:");
            hoone.GetUks().NaitaInfo();
        }
    }
}
