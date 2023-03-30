using System.Diagnostics;

namespace Jarai.CSharp.Objektorientierung1.Aggregation
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


        /// <summary>
        ///     Statischer Konstruktor (zur initialisierung von statischen Komponenten)
        ///     Klassen Initialisierer, wird ein einziges mal vor dem ersten Auto Konstruktor aufgerufen
        /// </summary>
        static Auto()
        {
            _anzahlAutos = 0;
            Debug.WriteLine("Statischer Konstruktor Auto");
        }


        /// <summary>
        ///     Default Konstruktor (ohne Parameter) erstellt Standard Autos
        /// </summary>
        public Auto()                       // Ruft den Konstruktor mit Parametern auf 
            : this("VW", Defaultfarbe, 50)  // "Constructor Chaining"
        {
            FahrgestellNr = ++_anzahlAutos;
            Debug.WriteLine("Standard Konstruktor Auto");
        }


        /// <summary>
        ///     "Universeller" Konstruktor mit Parametern
        /// </summary>
        public Auto(string marke, string farbe, int ps)
        {
            FahrgestellNr = ++_anzahlAutos;

            Marke = marke;
            Farbe = farbe;

            // Motor erstellen (new) und "einbauen"
            Motor = new Motor(ps);

            // Räder erstellen und "einbauen"
            for (int i = 0; i < 4; i++)
            {
                Räder[i] = new Rad();
            }

            Debug.WriteLine("Konstruktor mit Parametern Auto");
        }

        /// <summary>
        /// Fortlaufende Fahrgestellnummer des Autos (wird im Auto Constructor vergeben)
        /// </summary>
        public int FahrgestellNr { get; }

        /// <summary>
        /// Die änderbare Farbe des Autos
        /// </summary>
        public string Farbe { get; set; }

        /// <summary>
        /// Die Marke eine Autos kann nachträglich nicht geändert werden (Kein set Accessor!)
        /// </summary>
        public string Marke { get; }

        /// <summary>
        /// Der Motor des Autos
        /// Der Motor wird im Auto Constructor erstellt und eingebaut.
        /// </summary>
        public Motor Motor { get; }

        // Array mit 4 Rad-Referenzen anlegen
        // Die 4 Rad Objekte werden mit new im Auto Konstruktor erstellt
        public Rad[] Räder { get; } = new Rad[4];

        public double Tachostand { get; private set; }

        public double Tankinhalt { get; private set; }

        /// <summary>
        ///     zeigt ALLE Autodaten (incl. Motor und Rad) auf der Console an
        /// </summary>
        public void Anzeigen()
        {
            Debug.WriteLine(ToString());
        }

        /// <summary>
        /// Das Auto fährt eine strecke
        /// Motor wird automatisch angelassen und gestoppt (Start/Stop Automatic)
        /// </summary>
        public void Fahren(double strecke)
        {
            Motor.Anlassen();

            Tachostand += strecke;
            Tankinhalt -= strecke * Spritverbrauch / 100;

            Debug.WriteLine($"Auto fahren: Tachostand: {Tachostand}, Tankinhalt: {Tankinhalt}");

            Motor.Abstellen();
        }

        public void Tanken(double liter)
        {
            Tankinhalt += liter;
            Debug.WriteLine($"Auto tanken: Neuer Tankinhalt: {Tankinhalt}");
        }

        /// <summary>
        /// Liefert alle Daten/Eigenschaften des Autos (inkl. Motor und Rad Daten) als string
        /// </summary>
        public override string ToString()
        {
            string ergebnis = "==============================\n";
            ergebnis += "Marke     : " + Marke + "\n";
            ergebnis += "Tachostand: " + Tachostand + "\n";
            ergebnis += "Tankinhalt: " + Tankinhalt + "\n";
            ergebnis += "Fahrg.Nr  : " + FahrgestellNr + "\n";
            ergebnis += Motor + "\n";

            for (int i = 0; i < 4; i++)
            {
                ergebnis += Räder[i] + "\n";
            }

            return ergebnis;
        }
    }
}
