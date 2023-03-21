using System;       //wg. Console



namespace Jarai.CSharp.Basics.HelloWorld
{
    internal class Program
    {
        /// <summary>
        ///     Main ist der Einstiegspunkt der Anwendung
        ///     Main kann ohne Instanz aufgerufen werden (static)
        /// </summary>
        private static void Main()
        {
            Console.WriteLine("Ihr vorname?");

            string vorname; // Lokale Variable anlegen (überall möglich)
            vorname = Console.ReadLine();

            Console.WriteLine("Ihr nachname?");
            string nachname = Console.ReadLine(); // Besser: Variable anlegen UND gleich zuweisen

            // Textverkettung mit +
            Console.WriteLine("Guten Tag " + vorname + " " + nachname + " !");

            // Wartet auf eine Tastatureingabe (damit die App nicht sofort wieder geschlossen wird)
            Console.ReadLine();
        }
    }
}
