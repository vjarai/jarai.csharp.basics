using System.Diagnostics;

namespace Jarai.CSharp.Objektorientierung2.Inheritance
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

        public double Filialumsatz { get; private set; }
        public string Standort { get; }

        public void Show()
        {
            Debug.WriteLine("=======================================");
            Debug.WriteLine("Ikea in      : " + Standort);
            Debug.WriteLine("Filialumsatz : " + Filialumsatz);
            Debug.WriteLine("Konzernumsatz: " + Konzernumsatz);
        }

        public Möbel Verkaufen()
        {
            Console.WriteLine("Willkomen bei Ikea, was wollen Sie kaufen");

            string eingabe = Console.ReadLine();
            Möbel warenkorb = null;

            switch (eingabe)
            {
                case "Stuhl":
                    warenkorb = new Stuhl();
                    break;

                case "Tisch":
                    warenkorb = new Tisch();
                    break;

                default:
                    Console.WriteLine("Haben wir leider nicht");
                    break;
            }

            if (warenkorb != null) // Wurde etwas gekauft...?
            {
                // ja, an die Kasse gehen und zahlen
                Filialumsatz += warenkorb.Preis;
            }

            // Warenausgabe
            return warenkorb;
        }
    }
}
