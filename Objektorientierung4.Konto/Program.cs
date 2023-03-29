namespace Objektorientierung4.Konto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var meinKonto = new Konto("Fritz");
            var deinKonto = new Konto("Susi");

            meinKonto.Einzahlen(100);
            meinKonto.Abheben(20, 4711);
            meinKonto.Anzeigen();

            meinKonto.Überweisen(deinKonto, 4711, 10);
            deinKonto.Anzeigen();
        }
    }
}
