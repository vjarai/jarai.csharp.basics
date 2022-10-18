namespace Jarai.CSharp.Linq.Query
{
    public class Contact
    {
        public string Name { get; set; } = String.Empty;

        public string Ort { get; set; } = String.Empty;

        public int Postleitzahl { get; set; }

        public override string ToString()
        {
            return $"{Name} {Postleitzahl} {Ort}";
        }
    }
}
