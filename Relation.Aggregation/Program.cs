using System;

namespace Jarai.CSharp.Relation.Aggregation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // REFERENZ-Variable anlegen und ein neues Auto Objekt erstellen
            var meinAuto = new Auto("VW", "ROT", 50);

            //Methoden aufrufen
            meinAuto.Tanken(30);
            meinAuto.Fahren(1000);
            meinAuto.Anzeigen();

            Console.ReadLine();
        }
    }
}
