namespace Jarai.CSharp.Objektorientierung1.Aggregation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Auto meinAuto = new Auto();
            Cabrio meinCabrio = new Cabrio();

            Auto aktuellesFahrzeug = null;

            Console.WriteLine("Wollen Sie mit Cabrio oder Auto fahren (C/A)?");
            string eingabe = Console.ReadLine();

            if (eingabe == "A")
                aktuellesFahrzeug = meinAuto;
            else
                aktuellesFahrzeug = meinCabrio;

                                           // Spätes Binden wird benötigt, ZUR LAUFZEIT muss entschieden werden ob
            aktuellesFahrzeug.Fahren(100); // Auto.Fahren oder 2. Cabrio.Fahren aufgerufen wird
                                           // Methode Fahren muss in der Basisklasse virtual sein
                                           // und in der abgeleiteten Klasse override
            meinAuto.Anzeigen();
            meinCabrio.Anzeigen();

            Console.ReadLine();
        }
    }
}
