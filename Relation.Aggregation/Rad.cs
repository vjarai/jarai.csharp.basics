using System.Diagnostics;

namespace Jarai.CSharp.Objektorientierung1.Aggregation
{
    public class Rad
    {
        public double Luftdruck { get; } = 2.0;

        public Rad()
        {
            Console.WriteLine("Rad erstellt");
        }

        public void Anzeigen()
        {
            Console.WriteLine(ToString());
        }

        public override string ToString()
        {
            return "Luftdruck: " + Luftdruck;
        }
    }
}
