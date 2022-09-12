using System;

namespace Jarai.CSharp.Relation.Aggregation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // REFERENZ-Variable anlegen und ein Auto Objekt erstellen
            var meinAuto = new Auto("F-XY-100", "VW", "ROT", 50);

            //Methoden aufrufen
            meinAuto.Tanken(30);
            meinAuto.Fahren(1000);
            meinAuto.Anzeigen();

            Console.ReadLine();
        }
    }
}
