using System.Diagnostics;

namespace Jarai.CSharp.Relation.Aggregation
{
    public class Auto
    {
        // konstante Attribute MÜSSEN sofort initialisiert werden 
        // und sind IMPLIZIT Klassenvariablen (static), 
        // d.h. alle Instanzen haben den gleichen spritverbrauch
        private const int Spritverbrauch = 10; //Zur Compile Zeit constant

        // statische Attribute DÜRFEN sofort initialisiert werden
        // oder im statischen Konstruktor (s.u.)
        private static int _anzahlAutos;

        private static readonly string Defaultfarbe = "Blau";

        private readonly Motor _motor; // Auto HAT einen Motor (Aggregation)

        // Array mit 4 Rad-Referenzen anlegen
        // Die 4 Rad Objekte werden mit new im Auto Konstruktor erstellt
        private readonly Rad[] _rad = new Rad[4];


        /// <summary>
        ///     Statischer Konstruktor (zur initialisierung von statischen Komponenten)
        /// </summary>
        static Auto()
        {
            Debug.WriteLine("Statischer Konstruktor Auto");
        }


        /// <summary>
        ///     Default Konstruktor (ohne Parameter) erstellt standard Autos
        /// </summary>
        public Auto()
            : this("<unbekannt>", "VW", Defaultfarbe, 50) // Aufruf Konstruktor mit Parametern
        {
            FahrgestellNr = ++_anzahlAutos;
            Debug.WriteLine("Standard Konstruktor Auto");
        }


        /// <summary>
        ///     "Universeller" Konstruktor mit Parametern
        /// </summary>
        public Auto(string kfzKennzeichen, string marke, string farbe, int ps)
        {
            FahrgestellNr = ++_anzahlAutos;

            KfzKennzeichen = kfzKennzeichen;
            Marke = marke;
            Farbe = farbe;

            // Motor erstellen (new) und "einbauen"
            _motor = new Motor(ps);

            // Räder erstellen und "einbauen"
            for (int i = 0; i < 4; i++)
            {
                _rad[i] = new Rad();
            }

            Debug.WriteLine("Konstruktor mit Parametern Auto");
        }

        public int FahrgestellNr { get; }

        public string Farbe { get; set; }

        public string KfzKennzeichen { get; }

        // Readonly Attribute DÜRFEN NUR in einem Konstruktor geändert werden
        public string Marke { get; }

        public double Tachostand { get; private set; }

        public double Tankinhalt { get; private set; }

        /// <summary>
        ///     zeigt ALLE Autodaten (incl. Motor und Rad) an
        /// </summary>
        public void Anzeigen()
        {
            Debug.WriteLine(ToString());
        }

        public void Fahren(double strecke)
        {
            _motor.Anlassen();

            Tachostand += strecke;
            Tankinhalt -= strecke * Spritverbrauch / 100;

            Debug.WriteLine("Neuer tachostand:" + Tachostand);
            Debug.WriteLine("Neuer tankinhalt:" + Tankinhalt);

            _motor.Abstellen();
        }

        public void Tanken(double liter)
        {
            Tankinhalt += liter;
            Debug.WriteLine("Neuer Tankinhalt:" + Tankinhalt);
        }

        public override string ToString()
        {
            string ergebnis = "==============================\n";
            ergebnis += "Kfz.Kennz.: " + KfzKennzeichen + "\n";
            ergebnis += "Marke     : " + Marke + "\n";
            ergebnis += "Tachstand : " + Tachostand + "\n";
            ergebnis += "Tankinhalt: " + Tankinhalt + "\n";
            ergebnis += "Fahrg.Nr  : " + FahrgestellNr + "\n";
            ergebnis += _motor + "\n";

            for (int i = 0; i < 4; i++)
            {
                ergebnis += _rad[i] + "\n";
            }

            return ergebnis;
        }
    }
}
