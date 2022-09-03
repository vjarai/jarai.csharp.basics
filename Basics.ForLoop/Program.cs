using System;

namespace Jarai.CSharp.Basics.ForLoop
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            double summe = 0;

            for (int monat = 1; monat <= 12; monat++)
            {
                Console.WriteLine("Bitte Umsatz für monat {0:d} eingeben.", monat);
                string eingabe = Console.ReadLine();
                double umsatz = double.Parse(eingabe);

                summe += umsatz; // oder umständlicher: summe = Summe + umsatz;
            }

            Console.WriteLine("Jahressumme: " + summe);
            Console.ReadLine();
        }
    }
}
