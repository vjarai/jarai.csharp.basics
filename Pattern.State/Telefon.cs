using System.Diagnostics;

namespace Jarai.CSharp.Pattern.State
{
    /// <summary>
    ///  Ein Telefon HAT EINEN Telefonzustand
    ///  Beispiel für "Zustand Entwurfsmuster"
    /// </summary>
    public class Telefon
    {
        private Telefonzustand _aktuellerZustand;

        public Telefon()
        {
            _aktuellerZustand = new Aufgelegt();
        }

        public Telefonzustand AktuellerZustand
        {
            get
            {
                Console.WriteLine("\nAktueller Zustand: " + _aktuellerZustand);
                return _aktuellerZustand;
            }
            private set { _aktuellerZustand = value; }
        }

        public void Abheben()
        {
            // Die tatsächlich aufgerufene Methode ist abhängig vom aktuellen Zustand (spätes binden)
            AktuellerZustand = AktuellerZustand.Abheben(); // Delegation: 
        }

        public void AnnehmenAnruf()
        {
            AktuellerZustand = AktuellerZustand.AnnehmenAnruf();
        }


        public void Auflegen()
        {
            AktuellerZustand = AktuellerZustand.Auflegen();
        }

        public void Sprechen()
        {
            AktuellerZustand = AktuellerZustand.Sprechen();
        }

        public void Wählen()
        {
            AktuellerZustand = AktuellerZustand.Wählen();
        }
    }
}
