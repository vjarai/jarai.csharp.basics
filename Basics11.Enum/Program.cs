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

            // Text als enum parsen:
            // var eingabe = Console.ReadLine();
            // meineBestellung.Status =System.Enum.Parse<Bestellstatus>( eingabe);

        }
    }
}
