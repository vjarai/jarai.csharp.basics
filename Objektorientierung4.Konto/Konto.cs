using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Objektorientierung4.Konto
{
    public class Konto
    {
        private int _kontoNummer;
        private decimal _kontoStand;
        private string _kontoInhaber;
        private static int _anzahlKonten;
        private int _pin;

        public Konto(string kontoInhaber)
        {
            _kontoInhaber = kontoInhaber;
            _pin = 4711;
            _kontoNummer = ++_anzahlKonten;
        }

        public void Anzeigen()
        {
            Console.WriteLine($"Konto     : {_kontoNummer} \n" +
                              $"Inhaber   : {_kontoInhaber}\n" +
                              $"Kontostand: {_kontoStand} \n");
        }

        public void Einzahlen(decimal betrag)
        {
            _kontoStand += betrag;

            Console.WriteLine($"{betrag} EUR auf Konto {_kontoNummer} eingezahlt\n " +
                              $"Neuer Kontostand: {_kontoStand}");
        }

        public void Abheben(decimal betrag, int pin)
        {
            if (pin != _pin)
                throw new Exception("Falsche Pin!");

            if (betrag > _kontoStand)
                throw new Exception("Keine Deckung!");

            _kontoStand -= betrag;

            Console.WriteLine($"{betrag} EUR von Konto {_kontoNummer} abgehoben\n" +
                              $"Neuer Kontostand: {_kontoStand}");

        }

        public void Überweisen(Konto habenkonto, int pin, decimal betrag)
        {
            this.Abheben(betrag, pin);
            habenkonto.Einzahlen(betrag);
        }
    }
}
