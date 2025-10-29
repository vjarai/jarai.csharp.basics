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

            // Spätes Binden wird benötigt, ZUR LAUFZEIT muss entschieden
            aktuellesFahrzeug.Fahren(100); // Macht ZWEI verschiedene Sachen!!!! 1. Auto.Fahren aufrufen oder 2. Cabrio.Fahren

            meinAuto.Anzeigen();
            meinCabrio.Anzeigen();

            Console.ReadLine();
        }
    }
}
