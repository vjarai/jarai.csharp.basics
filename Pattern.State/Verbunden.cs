using System.Diagnostics;

namespace Jarai.CSharp.Pattern.State
{
    public class Verbunden : Telefonzustand
    {
        public Verbunden()
            : base("<Verbindung ist hergestellt>")
        {
        }

        public override Telefonzustand Auflegen()
        {
            Debug.WriteLine("Hörer wird aufgelegt.");
            return new Aufgelegt();
        }

        public override Telefonzustand Sprechen()
        {
            Debug.WriteLine("Es wird gesprochen.");
            return this;
        }
    }
}