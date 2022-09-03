using System.Diagnostics;

namespace Jarai.CSharp.Relation.Aggregation
{
    public class Auto
    {
        // konstante Attribute MÜSSEN sofort initialisiert werden 
        // und sind IMPLIZIT Klassenvariablen (static), 
        // d.h. alle Instanzen haben den gleichen spritverbrauch
        // Das Schlüsselwort static ist bei constanten NICHT gestattet.
        private const int Spritverbrauch = 10; //Zur Compile Zeit constant

        // statische Attribute DÜRFEN sofort initialisiert werden
        // oder im statischen Konstruktor (s.u.)
        private static int _anzahlAutos;

        private static readonly string Defaultfarbe = "Blau";

        private readonly string _kfzKennzeichen;

        // Readonly Attribute DÜRFEN NUR in einem Konstruktor geändert werden
        // und können Instanz oder Klassenvariablen sein
        private readonly string _marke; // Zur Laufzeit constant

        private readonly Motor _motor; // Auto HAT einen Motor (Aggregation)

// Array mit 4 Rad-Referenzen(!) anlegen
// (Die 4 Rad Objekte werden im Konstruktor in einer for Schleife erstellt)
        private readonly Rad[] _rad = new Rad[4];

        private double _tachostand;

        private double _tankinhalt;

        // Statischer Konstruktor für statische Komponenten
        static Auto()
        {
            Debug.WriteLine("Statischer Konstruktor Auto");
        }


        // Default Konstruktor (ohne Parameter)
        public Auto()
            : this("<unbekannt>", "VW", Defaultfarbe, 50) // Aufruf Konstruktor mit Parametern
        {
            FahrgestellNr = ++_anzahlAutos;
            Debug.WriteLine("Standard Konstruktor Auto");
        }

        //Konstruktor mit Parametern
        public Auto(string kfzKennzeichen, string marke, string farbe, int ps)
        {
            FahrgestellNr = ++_anzahlAutos;

            _kfzKennzeichen = kfzKennzeichen;
            _marke = marke;
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

        // "Normale" Attribute

        public string Farbe { get; set; }

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
            _tachostand += strecke;
            _tankinhalt -= strecke * Spritverbrauch / 100;


            Debug.WriteLine("Neuer tachostand:" + _tachostand);
            Debug.WriteLine("Neuer tankinhalt:" + _tankinhalt);
            _motor.Abstellen();
        }

        public void Tanken(double liter)
        {
            _tankinhalt += liter;
            Debug.WriteLine("Neuer Tankinhalt:" + _tankinhalt);
        }

        public override string ToString()
        {
            string ergebnis = "==============================\n";
            ergebnis += "Kfz.Kennz.: " + _kfzKennzeichen + "\n";
            ergebnis += "Marke     : " + _marke + "\n";
            ergebnis += "Tachstand : " + _tachostand + "\n";
            ergebnis += "Tankinhalt: " + _tankinhalt + "\n";
            ergebnis += "Fahrg.Nr  : " + FahrgestellNr + "\n";
            ergebnis += _motor + "\n";

            for (int i = 0; i < 4; i++)
            {
                ergebnis += _rad[i] + "\n";
            }

            return ergebnis;
        }

        ~Auto()
        {
            Debug.WriteLine("Destruktor (Finalize()) Auto");
        }
    }
}
