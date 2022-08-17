using System;

namespace Jarai.Basics.Conditionals
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Bitte Schulnote eingeben (1-6)");
            string eingabe = Console.ReadLine();

            int note = int.Parse(eingabe);

            #region Variante if else

            if (note == 1)
            {
                Console.WriteLine("Sehr gut");
            }
            else if (note == 2)
            {
                Console.WriteLine("Gut");
            }
            else if (note == 3)
            {
                Console.WriteLine("Befriedigend");
            }
            else if (note == 4)
            {
                Console.WriteLine("Ausreichend");
            }
            else if (note == 5)
            {
                Console.WriteLine("Mangelhaft");
            }
            else if (note == 6)
            {
                Console.WriteLine("Suboptimal");
            }
            else
            {
                Console.WriteLine("Fehleingabe");
            }

            #endregion

            #region Variante switch

            switch (note)
            {
                case 1:
                    Console.WriteLine("Sehr gut");
                    break;
                case 2:
                    Console.WriteLine("Gut");
                    break;
                case 3:
                    Console.WriteLine("Befriedigend");
                    break;
                case 4:
                    Console.WriteLine("Ausreichend");
                    break;
                case 5:
                    Console.WriteLine("Mangelhaft");
                    break;
                case 6:
                    Console.WriteLine("Suboptimal");
                    break;
                default:
                    Console.WriteLine("Fehleingabe");
                    break;
            }

            #endregion

            #region Variante array

            // Eleganteste Variante:
            // "Wählen Sie eine Datenstruktor, die Ihr Programm einfach macht..."

            // Array anlegen
            string[] noten = { "Sehr gut", "Gut", "Befriedigend", "Ausreichend", "Mangelhaft", "Ungenügend" };

            // Gültige Note?
            if (note >= 1 && note <= noten.Length)
            {
                Console.WriteLine("Das ist:" + noten[note - 1]); //Array mit der note INDIZIEREN
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe");
            }

            #endregion

            Console.ReadLine();
        }
    }
}
