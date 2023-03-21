using System.Diagnostics;

namespace Jarai.CSharp.Pattern.State
{
    public class Aufgelegt : Telefonzustand
    {
        public Aufgelegt()
            : base("<Hörer ist aufgelegt>")
        {
        }

        public override Telefonzustand Abheben()
        {
            Debug.WriteLine("Hörer wird abgehoben.");
            return new Abgehoben();
        }

        public override Telefonzustand AnnehmenAnruf()
        {
            Debug.WriteLine("Anruf wird angenommen.");
            return new Verbunden();
        }
    }
}