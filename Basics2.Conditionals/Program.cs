using System;

namespace Jarai.CSharp.Basics.Conditionals
{
    internal class Program
    {
        private static void Main()
        {
            Console.WriteLine("Bitte Schulnote eingeben (1-6)");
            string eingabe = Console.ReadLine();

            #region Variante if else

            if (eingabe == "1")
            {
                Console.WriteLine("Sehr gut");
            }
            else if (eingabe == "2")
            {
                Console.WriteLine("Gut");
            }
            else if (eingabe == "3")
            {
                Console.WriteLine("Befriedigend");
            }
            else if (eingabe == "4")
            {
                Console.WriteLine("Ausreichend");
            }
            else if (eingabe == "5")
            {
                Console.WriteLine("Mangelhaft");
            }
            else if (eingabe == "6")
            {
                Console.WriteLine("Suboptimal");
            }
            else
            {
                Console.WriteLine("Fehleingabe");
            }

            #endregion

            #region Variante switch

            switch (eingabe)
            {
                case "1":
                    Console.WriteLine("Sehr gut");
                    break; // nicht vergessen
                case "2":
                    Console.WriteLine("Gut");
                    break;
                case "3":
                    Console.WriteLine("Befriedigend");
                    break;
                case "4":
                    Console.WriteLine("Ausreichend");
                    break;
                case "5":
                    Console.WriteLine("Mangelhaft");
                    break;
                case "6":
                    Console.WriteLine("Suboptimal");
                    break;
                default:
                    Console.WriteLine("Fehleingabe");
                    break;
            }

        
            #endregion

            #region Variante array

            // Eleganteste Variante:
            // "Wählen Sie eine Datenstruktur, die Ihr Programm einfach macht..."

            // Array anlegen
            string[] notenTexte = { "Sehr gut", "Gut", "Befriedigend", "Ausreichend", "Mangelhaft", "Ungenügend" };

            int note = int.Parse(eingabe);  // Umwandlung Texteingabe in Zahl

            // Gültige Note?
            if (note >= 1 && note <= notenTexte.Length)  // && ist das logische Und
            {
                Console.WriteLine("Das ist:" + notenTexte[note - 1]); //Array mit der note INDIZIEREN
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
