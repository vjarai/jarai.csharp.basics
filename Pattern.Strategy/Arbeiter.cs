using System;

namespace Jarai.CSharp.Pattern.Strategy
{
    public abstract class Arbeiter  // Von abstrakten Klassen kann man KEINE Instanzen erstellen!
    {
        protected string Name { get; }  // Protected: Die Klasse und alle abgeleiteten Klassen können darauf zugreifen.

        public Arbeiter(string name)
        {
            Name = name;
        }

        public abstract void Arbeiten(); // Abstracte Methoden MÜSSEN überschrieben werden in abgeleiteten Klassen


        public virtual void Anzeigen() // Virtuelle Methoden DÜRFEN überschrieben werden in abgeleiteten Klassen
        {
            Console.WriteLine($"Arbeiter : {Name}");  // Schlechter Stil: Vermischung von Userinterface und Logic
        }

        public override string ToString()
        {
            return $"Arbeiter : {Name} ";
        }
    }
}
