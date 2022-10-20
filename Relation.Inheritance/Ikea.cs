using System;
using System.Diagnostics;
using System.Reflection;

namespace Jarai.CSharp.Relation.Inheritance
{
    public class Ikea
    {
        private static readonly double Konzernumsatz;

        static Ikea()
        {
            Konzernumsatz = 0;
        }

        public Ikea(string standort)
        {
            Standort = standort;
            Filialumsatz = 0;
        }

        public double Filialumsatz { get;private set; }
        public string Standort { get; }

        public void Show()
        {
            Debug.WriteLine("=======================================");
            Debug.WriteLine("Ikea in      : " + Standort);
            Debug.WriteLine("Filialumsatz : " + Filialumsatz);
            Debug.WriteLine("Konzernumsatz: " + Konzernumsatz);
        }

        public Möbel? Verkaufen()
        {
            Console.WriteLine("Willkomen bei Ikea, was wollen Sie kaufen");

            string? eingabe = Console.ReadLine();
            Möbel? neuesMöbel = null;

            switch (eingabe)
            {
                case "Stuhl":
                    neuesMöbel = new Stuhl();
                    break;

                case "Tisch":
                    neuesMöbel = new Tisch();
                    break;

                default:
                    Console.WriteLine("Haben wir leider nicht");
                    break;
            }

            if (neuesMöbel != null)  // Wurde etwas gekauft...?
            {
                // ja, an die Kasse gehen und zahlen
                Filialumsatz += neuesMöbel.Preis;
            }

            // Warenausgabe
            return neuesMöbel;
        }

        /*
        public Möbel Verkaufen2()
        {
            Console.WriteLine($"Willkommen bei Ikea {Standort}.");
            Console.WriteLine("Was möchten Sie kaufen? (Tisch, Stuhl oder Leer).");

            string eingabe = Console.ReadLine();

            if (string.IsNullOrEmpty(eingabe))
            {
                return null;
            }

            string typeName = GetType().Namespace + "." + eingabe;

            // Instanz via Reflection über den Klassennamen erstellen
            var möbel = (Möbel)Assembly.GetExecutingAssembly().CreateInstance(typeName, true);

            return möbel;
        }
        */
    }
}
