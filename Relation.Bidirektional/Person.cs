using System;
using System.Diagnostics;

namespace Jarai.Relation.Bidirectional
{
    public class Person
    {
        private readonly string _geburtsname;
        private readonly string _vorname;
        private int _anzahlEhen;
        private string _nachname;
        private Person _partner;

        public Person(string vorname, string nachname)
        {
            _vorname = vorname;
            _nachname = _geburtsname = nachname;
        }

        public string Anzeigen()
        {
            string ergebnis = "Guten Tag ich heisse " + _vorname + " " + _nachname;

            if (_geburtsname != _nachname)
            {
                ergebnis += " (geburtsname " + _geburtsname + ")";
            }

            // verheiratet ?
            if (_partner == null)
            {
                ergebnis += " und bin " + (_anzahlEhen == 0 ? "ledig." : "geschieden.");
            }
            else
            {
                ergebnis += " und bin verheiratet mit " + _partner._vorname + " " + _partner._nachname;
            }

            Debug.WriteLine(ergebnis);

            return ergebnis;
        }

        public void Heiraten(Person neuerPartner)
        {
            // heirate ich eine null?
            if (neuerPartner == null)
            {
                throw new Exception(_vorname + " " + _nachname + " kann keine \"null\" heiraten");
            }

            // heirate ich mich selbst?
            if (neuerPartner == this)
            {
                throw new Exception(_vorname + " " + _nachname + " kann sich nicht selbst heiraten");
            }

            // Bin ich bereits verheiratet?
            if (_partner != null)
            {
                throw new Exception(_vorname + " " + _nachname + " ist bereits verheiratet");
            }

            // Ist mein partner verheiratet?
            if (neuerPartner._partner != null)
            {
                throw new Exception(neuerPartner._vorname + " " + neuerPartner._nachname + " ist bereits verheiratet");
            }

            // ich habe einen neuen partner
            _partner = neuerPartner;

            // Der partner meines partners bin ich
            neuerPartner._partner = this;

            // mein partner nimmt meinen Namen an
            neuerPartner._nachname = _nachname;

            ++_anzahlEhen;
            ++neuerPartner._anzahlEhen;
        }

        public void Trennen()
        {
            if (_partner == null)
            {
                throw new Exception(_vorname + " " + _nachname + " ist nicht verheiratet.");
            }

            // Mein partner nimmt wieder seinen geburtsnamen an
            _partner._nachname = _partner._geburtsname;

            // Ich nehme wieder meinen geburtsnamen an
            _nachname = _geburtsname;

            // Mein partner hat keinen partner mehr
            _partner._partner = null;

            // Ich habe keinen partner mehr.
            _partner = null;
        }
    }
}
