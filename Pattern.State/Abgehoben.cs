using System.Diagnostics;

namespace Jarai.CSharp.Pattern.State
{
    public class Abgehoben : Telefonzustand
    {
        public Abgehoben()
            : base("<Hörer ist abgenommen>")
        {
        }

        public override Telefonzustand Auflegen()
        {
            Console.WriteLine("Hörer wird aufgelegt.");
            return new Aufgelegt();
        }

        public override Telefonzustand Wählen()
        {
            Console.WriteLine("Rufnummer wird gewählt.");
            return new Verbunden();
        }
    }
}