using System.Diagnostics;

namespace Jarai.CSharp.Objektorientierung4.Bidirectional
{
    public class Person
    {
        private readonly string _geburtsname;
        private int _anzahlEhen;

        public Person(string vorname, string nachname)
        {
            Vorname = vorname;
            Nachname = _geburtsname = nachname;
        }

        public string Vorname { get; }
        public string Nachname { get; private set; }
        public Person? Partner { get; private set; }

        public override string ToString()
        {
            string ergebnis = "Guten Tag ich heisse " + Vorname + " " + Nachname;

            if (_geburtsname != Nachname)
            {
                ergebnis += " (geburtsname " + _geburtsname + ")";
            }

            // verheiratet ?
            if (Partner == null)
            {
                ergebnis += " und bin " + (_anzahlEhen == 0 ? "ledig." : "geschieden.");
            }
            else
            {
                ergebnis += " und bin verheiratet mit " + Partner.Vorname + " " + Partner.Nachname;
            }

            Debug.WriteLine(ergebnis);

            return ergebnis;
        }

        public void Heiraten(Person neuerPartner)
        {
            // ToDo: Alle Person Tests sollen grün sein...
        }

        public void Trennen()
        {
            // ToDo: Alle Person Tests sollen grün sein...
        }
    }
}
