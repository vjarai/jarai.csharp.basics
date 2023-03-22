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
            Console.WriteLine("Hörer wird abgehoben.");
            return new Abgehoben();
        }

        public override Telefonzustand AnnehmenAnruf()
        {
            Console.WriteLine("Anruf wird angenommen.");
            return new Verbunden();
        }
    }
}