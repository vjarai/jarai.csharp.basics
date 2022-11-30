namespace Jarai.CSharp.Basics.NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nullable<bool> esWirdRegnen;

            // Oder kürzer mit ?
            bool? esWirdRegnen;

            esWirdRegnen = null;
            esWirdRegnen = true;
            esWirdRegnen = false;

            // Abfrage, ob der Wert von esWirdRegnen gesetzt ist
            if (!esWirdRegnen.HasValue)
                Console.WriteLine("Ich weis nicht, ob es regnet.");
            else
                Console.WriteLine($"Es wird regnen: {esWirdRegnen}");

            // Der Coalesce operator (??) übernimmt den rechten Wert als Default, wenn die linke Seite null ist
            esWirdRegnen = esWirdRegnen ?? true;

            Console.WriteLine($"Wert von x: {esWirdRegnen}");

            Console.ReadLine();
        }
    }
}
