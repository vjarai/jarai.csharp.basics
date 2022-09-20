using System.Diagnostics;

namespace Jarai.CSharp.Relation.Aggregation
{
    public class Rad
    {
        public double Luftdruck { get; } = 2.0;

        public Rad()
        {
            Debug.WriteLine("Rad erstellt");
        }

        public void Anzeigen()
        {
            Debug.WriteLine(ToString());
        }

        public override string ToString()
        {
            return "Luftdruck: " + Luftdruck;
        }
    }
}
