using System.Diagnostics;

namespace Jarai.Relation.Aggregation
{
    public class Rad
    {
        private readonly double _luftdruck = 2.0;

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
            return "Luftdruck: " + _luftdruck;
        }
    }
}
