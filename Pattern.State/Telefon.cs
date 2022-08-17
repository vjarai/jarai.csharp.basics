using System;
using System.Diagnostics;

namespace Jarai.Pattern.State
{
    public class Telefon
    {
        // Ein Telefon hat einen zustand
        // Beispiel für "Zustand Entwurfsmuster"

        public Telefon()
        {
            AktuellerZustand = new Aufgelegt();
            if (OnAufgelegt != null)
                OnAufgelegt(this, null);
        }

        public Zustand AktuellerZustand { get; private set; }

        public void Abheben()
        {
            Debug.WriteLine("\nAktueller Zustand: " + AktuellerZustand);
            // Die tatsächliche aktion ist abhängig vom aktuellen Zustand
            // (spätes binden)
            if (AktualisiereZustand(AktuellerZustand.Abheben()))
                if (OnAbgehoben != null)
                    OnAbgehoben(this, null);
        }

        public void AnnehmenAnruf()
        {
            Debug.WriteLine("\nAktueller Zustand: " + AktuellerZustand);

            if (AktualisiereZustand(AktuellerZustand.AnnehmenAnruf()))
                if (OnVerbunden != null)
                    OnVerbunden(this, null);
        }


        public void Auflegen()
        {
            Debug.WriteLine("\nAktueller Zustand: " + AktuellerZustand);
            if (AktualisiereZustand(AktuellerZustand.Auflegen()))
                if (OnAufgelegt != null)
                    OnAufgelegt(this, null);
        }

        public void Sprechen()
        {
            Debug.WriteLine("\nAktueller Zustand: " + AktuellerZustand);
            AktuellerZustand = AktuellerZustand.Sprechen();
        }

        public void Wählen()
        {
            Debug.WriteLine("\nAktueller Zustand: " + AktuellerZustand);
            if (AktualisiereZustand(AktuellerZustand.Wählen()))
                if (OnVerbunden != null)
                    OnVerbunden(this, null);
        }

        public event EventHandler OnAbgehoben;

        public event EventHandler OnAufgelegt;
        public event EventHandler OnVerbunden;

        public event EventHandler OnZustandGeändert;

        private bool AktualisiereZustand(Zustand neuerZustand)
        {
            var istGeändert = false;

            if (AktuellerZustand != neuerZustand)
            {
                istGeändert = true;
                AktuellerZustand = neuerZustand;
                if (OnZustandGeändert != null)
                    OnZustandGeändert(this, null);
            }

            return istGeändert;
        }
    }
}
