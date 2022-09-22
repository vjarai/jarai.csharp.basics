using System;

namespace Jarai.CSharp.Pattern.Strategy
{
    public class Maler : Arbeiter
    {
        public Maler(string name) : base(name)
        {
        }

        public override void Arbeiten()
        {
            Console.WriteLine("- weiße Wand produziert durch '{0}'", Name);
        }

        public override void Anzeigen()
        {
            base.Anzeigen();
            Console.WriteLine($"Maler streicht die Wand.");

        }

        public override string ToString()  // Override: Die virtuelle Methode aus der Basisklasse wird überschrieben
        {
            return "Maler " + base.ToString() + " streicht eine Wand.";
        }
    }
}
