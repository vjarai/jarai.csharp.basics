using System;

namespace Jarai.CSharp.Basics.Zahlenraten
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            string nochEinmal;

            do
            {
                // Variablen definieren
                int tipp, anzahlVersuche = 0;

                // Berechnung Zufallszahl
                int geheimzahl = new Random().Next(1, 101);

                // Schummelfunktion (nur zum Debuggen)
                // Console.WriteLine("Geheimzahl:" + geheimzahl);

                Console.WriteLine("Willkommen zum fröhlichen Zahlenraten (zwischen 1 und 100)!");

                do
                {
                    Console.WriteLine("Bitte Tipp eingeben: ");
                    tipp = int.Parse(Console.ReadLine());

                    anzahlVersuche++;

                    if (tipp > geheimzahl)
                    {
                        Console.WriteLine("Leider zu groß...");
                    }
                    else if (tipp < geheimzahl)
                    {
                        Console.WriteLine("Leider zu klein...");
                    }

                } while (tipp != geheimzahl);

                Console.WriteLine($"Gewonnen !\nUnd das mit nur {anzahlVersuche} Versuchen!!!");



                Console.WriteLine("Noch einmal? (J/N)");
                nochEinmal = Console.ReadLine();

            } while (nochEinmal == "J" || nochEinmal == "j");
        }
    }
}
