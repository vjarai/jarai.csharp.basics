using System;

namespace Jarai.CSharp.Relation.Bidirectional
{
    public class Person
    {
        private readonly string _geburtsname;
        private int _anzahlEhen;

        public Person(string vorname, string nachname)
        {
            // TODO...
        }

        public string Nachname { get; }

        public Person Partner { get; private set; }
        
        public string Vorname { get; }

        public string Anzeigen()
        {
            // TODO...

            throw new NotImplementedException();
        }

        public void Heiraten(Person neuerPartner)
        {
            // TODO...

            throw new NotImplementedException();
        }

        public void Trennen()
        {
            // TODO...

            throw new NotImplementedException();
        }
    }
}
