namespace Jarai.CSharp.Linq.Query
{
    public class Adressbook
    {
        public Adressbook()
        {
            Contacts = new[]
            {
                new Contact { Name = "Fritz Müller", Postleitzahl = 12345, Ort = "Berlin" },
                new Contact { Name = "Susi Müller", Postleitzahl = 12345, Ort = "Berlin" },
                new Contact { Name = "Franz Meier", Postleitzahl = 13456, Ort = "Berlin" },
                new Contact { Name = "Bart Simpson", Postleitzahl = 81234, Ort = "München" },
                new Contact { Name = "Viktor Jarai", Postleitzahl = 65779, Ort = "Kelkheim" }
            };
        }

        public Contact[] Contacts { get; }
    }
}
