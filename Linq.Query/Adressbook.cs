namespace Jarai.CSharp.Linq.Query
{
    public class Adressbook
    {
        public Adressbook()
        {
            // Das Contacts Array mit Testdaten füllen...
            Contacts = new[]
            {
                new Contact { Name = "Fritz Müller", Postleitzahl = 12345, Ort = "Berlin" },
                new Contact { Name = "Susi Müller", Postleitzahl = 12345, Ort = "Berlin" },
                new Contact { Name = "Franz Meier", Postleitzahl = 13456, Ort = "Berlin" },
                new Contact { Name = "Bart Simpson", Postleitzahl = 81234, Ort = "München" },
                new Contact { Name = "Viktor Jarai", Postleitzahl = 65779, Ort = "Kelkheim" }
            };
        }

        /// <summary>
        /// Array aller in diesem Adressbuch gespeicherten Adressen
        /// (In der Praxis würde man statt des Arrays eine generische Liste nehmen...)
        /// </summary>
        public Contact[] Contacts { get; }
    }
}
