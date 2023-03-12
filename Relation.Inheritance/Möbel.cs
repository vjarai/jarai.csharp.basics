using System;

namespace Jarai.CSharp.Relation.Inheritance
{
    /// <summary>
    /// Wenn eine Klasse mindestens eine abstracte Methode enthält,
    /// wird die Klasse zur abstracten Basisclasse.
    /// Von abstracten Klassen kann keine Instanz erstellt werden.
    /// </summary>
    public abstract class Möbel
    {
        public bool IsAssembled { get; set; } = false;

        public string Name { get; }

        public double Preis { get; }


        protected Möbel(string name, double preis)
        {
            Name = name;
            Preis = preis;
        }

        public abstract void Benutzen(); // Abstracte Methoden MÜSSEN überschrieben werden

        public abstract void Montieren(); // und können in der Basisklasse NICHT implementiert werden

        protected void ThrowExceptionIfNotAssembled()
        {
            if (!IsAssembled)
                throw new MoebelNichtMontiertException("Möbel ist nicht montiert.");
        }
    }
}
