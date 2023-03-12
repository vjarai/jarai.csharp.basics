namespace Pattern.Factory
{
    internal class Ikea
    {

        public static decimal Konzernumsatz { get; set; }

        public decimal FilialUmsatz { get; set; }
        public string Standort { get; set; }

        public Ikea(string standort)
        {
            Standort = standort;
        }

        public Möbel Verkaufen()
        {
            Console.WriteLine("Willkommen bei Ikea, was wollen Sie kaufen (S,T)?");
            string eingabe = Console.ReadLine();

            Möbel neuesMöbel;

            if (eingabe == "S")
            {
                neuesMöbel = new Stuhl(50);
            }
            else
            {
                neuesMöbel = new Tisch(100);
            }

            // An die Kasse gehen und bezahlen
            FilialUmsatz +=  neuesMöbel.Preis;
            Konzernumsatz += neuesMöbel.Preis;

            // Warenausgabe, Möbel wird ausgehändigt
            return neuesMöbel;
        }

        public void AnzeigenFilialUmsatz()
        {
            Console.Write($" Umsatz in {Standort} : {FilialUmsatz}");
        }

        public static void AnzeigenKonzernUmsatz()
        {
            Console.Write($" Konzernumsatz von IKEA : {Konzernumsatz}");
        }
    }
}
