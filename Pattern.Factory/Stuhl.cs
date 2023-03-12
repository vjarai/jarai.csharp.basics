using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern.Factory
{
    public class Stuhl : Möbel
    {
       

        public override void Benutzen()
        {
            Console.WriteLine("Stuhl wird benutzt.");
        }

        public override void Montieren()
        {
            Console.WriteLine("Stuhl wird montiert.");
        }

        public Stuhl(decimal preis) : base(preis)
        {
        }
    }
}
