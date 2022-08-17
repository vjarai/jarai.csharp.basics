using System;

namespace Jarai.Basics.DoLoop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int anzahl = 0;
            double summe = 0, umsatz;
            double maxUmsatz = double.MinValue;
            double minUmsatz = double.MaxValue;

            do
            {
                Console.WriteLine("Bitte Umsatz eingeben (0 für Ende).");
                string eingabe = Console.ReadLine();
                umsatz = double.Parse(eingabe);

                if (umsatz != 0)
                {
                    if (umsatz > maxUmsatz)
                    {
                        maxUmsatz = umsatz;
                    }

                    if (umsatz < minUmsatz)
                    {
                        minUmsatz = umsatz;
                    }

                    summe += umsatz;
                    anzahl++;
                }
            } while (umsatz != 0);

            Console.WriteLine("Summe     : " + summe);
            Console.WriteLine("Mittelwert: " + (summe / anzahl));
            Console.WriteLine("Maximum   : " + maxUmsatz);
            Console.WriteLine("Minimum   : " + minUmsatz);

            Console.ReadLine();
        }
    }
}
