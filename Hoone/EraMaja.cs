using System;
using System.Collections.Generic;
using System.Text;

namespace Hoone
{
    public class EraMaja : Hoone
    {
        int suurus;





        public EraMaja(int pindala = 50) : base(pindala)
        {
        }
        public string Staatus
        {
            get
            {
                var staatus = "";
                if (suurus < 20)
                {
                    staatus = "vaike maja";
                }
                else if (suurus < 60)
                {
                    staatus = "keskmine maja";
                }
                else if (suurus < 100)
                {
                    staatus = "suur maja";
                }
                else
                {
                    staatus = "liiga suur maja";
                }
                return staatus;
            }
        }
        public override void NaitaInfo()
        {
            Console.WriteLine($"Ma olen {Staatus}");
        }
    }
}
