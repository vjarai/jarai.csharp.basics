using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Pattern.Factory
{
    public class Tisch : Möbel
    {
        public override void Benutzen()
        {
            Console.WriteLine("Tisch wird benutzt.");
        }

        public override void Montieren()
        {
            Console.WriteLine("Tisch wird montiert.");
        }

        public Tisch(decimal preis) : base(preis)
        {
        }
    }
}
