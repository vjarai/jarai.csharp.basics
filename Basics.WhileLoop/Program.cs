using System;

namespace Jarai.Basics.WhileLoop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Wieviel Geld nehmen Sie heute mit zum einkaufen?");
            string eingabe = Console.ReadLine();
            double geld = double.Parse(eingabe);

            while (geld > 0)
            {
                Console.WriteLine("Preis? (Restgeld {0:c})", geld); // {0:c} Platzhalter für Währungsformat
                eingabe = Console.ReadLine();
                double preis = double.Parse(eingabe);

                if (preis == 0) // Handy klingelt?
                {
                    break; // dann Kaufrausch-Schleife verlassen
                }

                if (preis > geld) // Artikel zu teuer?
                {
                    Console.WriteLine("Leider zu teuer"); // dann Meldung ausgeben
                }
                else // ansonsten...
                {
                    geld -= preis; // ...zur Kasse gehen und zahlen
                }
            }

            Console.WriteLine("Willkommen daheim! Restgeld: {0:c}", geld);
            Console.ReadLine();
        }
    }
}
