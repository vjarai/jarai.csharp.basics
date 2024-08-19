using System;

namespace Jarai.CSharp.Basics.Exceptions
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            int anzahlPersonen;
            int anzahlKuchen;

            Console.WriteLine("Wieviele Personen?");
            string eingabe = Console.ReadLine(); // OK: Variable anlegen UND sofort zuweisen

            try // Umwandlung versuchen...
            {
                anzahlPersonen = int.Parse(eingabe);
            }
            catch (Exception ex) // den Laufzeitfehler bei nichtnumerischer Eingabe abfangen
            {
                Console.WriteLine("Ungültige Eingabe bei Personen:" + ex.Message);
                return;
            }

            Console.WriteLine("Wieviele Kuchen?");
            eingabe = Console.ReadLine();

            try
            {
                anzahlKuchen = int.Parse(eingabe);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ungültige Eingabe bei Kuchen:" + ex.Message);
                throw; // rethrow, erhält den ursprünglichen CallStack
            }
            finally
            {
                // Der finally Block wird auf jedem Fall ausgeführt,
                // ideal um Resourcen freizugeben (Close).
            }


            if (anzahlPersonen == 0 || anzahlKuchen == 0)
            {
                // Auslösen einer Exception mit throw new ...
                throw new Exception("Party fällt leider aus!");
            }

            // Hier ist mindestens eine EXPLIZITE Typkonversion ("CAST") notwendig
            // Bei Division von int durch int würde die int Division verwendet (keine Nachkommastellen)
            // Sobald ein Parameter der Division ein double ist, wird der zweite IMPLIZIT auf double gecastet
            double ergebnis = (double)anzahlKuchen / anzahlPersonen;

            // Ausgabe mit Platzhalter und Formatspezifikation
            Console.WriteLine("Kuchen pro Person: {0:f2} ", ergebnis);

            // Ausgabe mit TEXT-Verkettung "+" (Ergebnis wird implizit in string gewandelt)
            Console.WriteLine("Kuchen pro Person: " + ergebnis); // Hier Implizite Typkonversion double => string

            // Besser: Ausgabe mit string interpolation
            Console.WriteLine($"Kuchen pro Person: {ergebnis:F2}");


            Console.ReadLine();
        }
    }
}
