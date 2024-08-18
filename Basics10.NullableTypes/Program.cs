namespace Jarai.CSharp.Basics.NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int regenWahrscheinlichkeit = new Random().Next(1, 100);

            // Nullable<bool> esWirdRegnen;
            // Oder kürzer mit ?
            bool? esWirdRegnen; // Es gibt DREI Zustände: true, false, null

            if (regenWahrscheinlichkeit < 30)
                esWirdRegnen = false;
            else if (regenWahrscheinlichkeit > 70)
                esWirdRegnen = true;
            else 
                esWirdRegnen = null;  // null bedeutet: "Ich weiß es nicht"
                                      // => Best practice: nullwerte möglichst vermeiden!

            // Abfrage, ob der Wert von esWirdRegnen gesetzt ist
            if (esWirdRegnen.HasValue)
                Console.WriteLine($"Es wird regnen: {esWirdRegnen}");
            else
                Console.WriteLine("Wir wissen nicht, ob es regnen wird.");

            // Der Coalesce operator (??) übernimmt den rechten Wert als Default, wenn die linke Seite null ist
            bool regenschirmMitnehmen = esWirdRegnen ?? true; 

            Console.WriteLine($"Regenschirm mitnehmen: {regenschirmMitnehmen}");

            Console.ReadLine();
        }
    }
}
