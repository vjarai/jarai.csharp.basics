namespace Jarai.CSharp.Basics.NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Nullable<bool> esRegnet;

            // Oder einfacher mit ?
            bool? esRegnet;

            esRegnet = null;
            esRegnet = true;
            esRegnet = false;

            // Abfrage, ob der Wert von esRegnet gesetzt ist
            if (!esRegnet.HasValue)
                Console.WriteLine("Ich weis nicht, ob es regnet.");
            else
                Console.WriteLine($"Wert von esRegnet ist: {esRegnet}");

            // Der Coalesce operator (??) übernimmt den rechten Wert als Default, wenn die linke Seite null ist
            esRegnet = esRegnet ?? true;

            Console.WriteLine($"Wert von x: {esRegnet}");

            Console.ReadLine();
        }
    }
}
