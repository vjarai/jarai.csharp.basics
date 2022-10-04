namespace Basics10.NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nullable Variablen werden mit ? deklariert
            int? x = null;
            
            // Abfrage, ob der Wert von x gesetzt wurde
            if(!x.HasValue)
                Console.WriteLine("Der Wert von x ist unbekannt (null)!");

            // Der Coalesce operator (??) übernimmt den rechten Wert als Default, wenn die linke Seite null ist
            var y = x ?? 100;

            Console.WriteLine($"Wert von y ist jetzt: {y}");

            x = 1;

            Console.WriteLine($"Wert von x ist jetzt: {x}");

            Console.ReadLine();
        }
    }
}
