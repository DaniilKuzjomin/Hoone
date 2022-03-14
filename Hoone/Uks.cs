using System;
using System.Collections.Generic;
using System.Text;

namespace Hoone
{
    public class Uks : Hoone
    {   
        public string Color { get; set; }

        public Uks(string color = "sinine")
        {
            Color = color;
        }

        public override void NaitaInfo()
        {
            Console.WriteLine($"Mina olen uks, minu värv on {Color}");
        }
    }
}
