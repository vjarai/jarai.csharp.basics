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
            Debug.WriteLine("Hörer wird aufgelegt.");
            return new Aufgelegt();
        }

        public override Telefonzustand Wählen()
        {
            Debug.WriteLine("Rufnummer wird gewählt.");
            return new Verbunden();
        }
    }
}