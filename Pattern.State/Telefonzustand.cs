using System;
using System.Diagnostics;

namespace Jarai.CSharp.Pattern.State
{
    public abstract class Telefonzustand  // Abstracte Klasse: Reine Basisklasse, d.h. es können keine Instanzen erstellt werden
    {
        protected Telefonzustand(string bezeichnung)
        {
            Bezeichnung = bezeichnung;
        }

        public string Bezeichnung { get; }

        public virtual Telefonzustand Abheben()
        {
            throw new InvalidOperationException("Sie können derzeit den Hörer nicht abheben.");
        }

        public virtual Telefonzustand AnnehmenAnruf()
        {
            throw new InvalidOperationException("Sie können derzeit keinen Anruf annehmen.");
        }

        public virtual Telefonzustand Auflegen()
        {
            throw new InvalidOperationException("Sie können derzeit den Hörer nicht auflegen.");
        }

        public virtual Telefonzustand Sprechen()
        {
            throw new InvalidOperationException("Sie können derzeit nicht sprechen.");
        }


        public override string ToString()
        {
            return Bezeichnung;
        }

        public virtual Telefonzustand Wählen()
        {
            throw new InvalidOperationException("Sie können derzeit keine Nummer wählen.");
        }
    }
}
