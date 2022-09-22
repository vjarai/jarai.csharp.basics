using System;

namespace Jarai.CSharp.Pattern.Strategy
{
    public class Schreiner : Arbeiter
    {
        public Schreiner(string name) : base(name)
        {
        }

        public override void Arbeiten()  // Override: Die abstrakte Methode aus der Basisklasse wird überschrieben
        {
            Console.WriteLine("- Schrank produziert durch '{0}'", Name);
        }

        public override void Anzeigen()  // Override: Die virtuelle Methode aus der Basisklasse wird überschrieben
        {
             base.Anzeigen();
             Console.WriteLine($"Schreiner baut einen Schrank");
        }


        public override string ToString()  // Override: Die virtuelle Methode aus der Basisklasse wird überschrieben
        {
           return   "Schreiner " + base.ToString() + " baut einen Schrank";
        }

    }
}
