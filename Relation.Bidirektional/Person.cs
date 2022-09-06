using System;
using System.Diagnostics;

namespace Jarai.CSharp.Relation.Bidirectional
{
    public class Person
    {
        private readonly string _geburtsname;
        private readonly string _vorname;
        private int _anzahlEhen;
        private string _nachname;
        public Person Partner { get; private set; }

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
            if (Partner == null)
            {
                ergebnis += " und bin " + (_anzahlEhen == 0 ? "ledig." : "geschieden.");
            }
            else
            {
                ergebnis += " und bin verheiratet mit " + Partner._vorname + " " + Partner._nachname;
            }

            Debug.WriteLine(ergebnis);

            return ergebnis;
        }

        public void Heiraten(Person neuerPartner)
        {
            // heirate ich eine null?
            if (neuerPartner == null)
            {
                throw new InvalidOperationException(_vorname + " " + _nachname + " kann keine \"null\" heiraten");
            }

            // heirate ich mich selbst?
            if (neuerPartner == this)
            {
                throw new InvalidOperationException(_vorname + " " + _nachname + " kann sich nicht selbst heiraten");
            }

            // Bin ich bereits verheiratet?
            if (Partner != null)
            {
                throw new InvalidOperationException(_vorname + " " + _nachname + " ist bereits verheiratet");
            }

            // Ist mein partner verheiratet?
            if (neuerPartner.Partner != null)
            {
                throw new InvalidOperationException(neuerPartner._vorname + " " + neuerPartner._nachname + " ist bereits verheiratet");
            }

            // ich habe einen neuen partner
            Partner = neuerPartner;

            // Der partner meines partners bin ich
            neuerPartner.Partner = this;

            // mein partner nimmt meinen Namen an
            neuerPartner._nachname = _nachname;

            ++_anzahlEhen;
            ++neuerPartner._anzahlEhen;
        }

        public void Trennen()
        {
            if (Partner == null)
            {
                throw new InvalidOperationException(_vorname + " " + _nachname + " ist nicht verheiratet.");
            }

            // Mein partner nimmt wieder seinen geburtsnamen an
            Partner._nachname = Partner._geburtsname;

            // Ich nehme wieder meinen geburtsnamen an
            _nachname = _geburtsname;

            // Mein partner hat keinen partner mehr
            Partner.Partner = null;

            // Ich habe keinen partner mehr.
            Partner = null;
        }
    }
}
