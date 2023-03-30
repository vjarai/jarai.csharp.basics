namespace Basics11.Enum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var meineBestellung = new Bestellung();

            meineBestellung.Status = Bestellstatus.ImWarenkorb;

            meineBestellung.Status = Bestellstatus.Versendet;

            meineBestellung.Status = Bestellstatus.Geliefert;
        }
    }
}
