using System;

namespace Jarai.CSharp.Relation.Aggregation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            // REFERENZ-Variable anlegen vom Typ Auto

            // Auto Objekt erstellen mit new
            var meinAuto = new Auto("F-XY-100", "VW", "ROT", 50);

            //Methoden aufrufen
            meinAuto.Tanken(30);
            meinAuto.Fahren(1000);
            meinAuto.Anzeigen();

            // Die Verbindung zwischen Variable und Object trennen
            meinAuto = null;

            // "Müllabfuhr anrufen" => GarbageCollection "manuelle" auslösen (eigentlich überflüssig)
            // Herrenlose Ojecte werden abgeräumt (Speicher wird freigegeben)
            GC.Collect();

            Console.ReadLine();
        }
    }
}
