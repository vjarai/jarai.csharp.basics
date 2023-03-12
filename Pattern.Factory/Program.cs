namespace Pattern.Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // In Frankfurt gibt es eine Ikea Filiale
            var ikeaFrankfurt = new Ikea("Frankfurt");

            // In Berlin gibt es eine Ikea Filiale
            var ikeaBerlin = new Ikea("Berlin");

            // Mein Möbel habe ich bei Ikea Berlin gekauft.
            Möbel meinMöbel = ikeaBerlin.Verkaufen();  // Factory Methode

            // Mein Möbel wurde montiert
            meinMöbel.Montieren();  

            // Mein Möbel wurde benutzt
            meinMöbel.Benutzen();


            ikeaBerlin.AnzeigenFilialUmsatz();
            ikeaFrankfurt.AnzeigenFilialUmsatz();

            Ikea.AnzeigenKonzernUmsatz();

        }
    }
}
