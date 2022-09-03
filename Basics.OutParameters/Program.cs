using System;

namespace Jarai.CSharp.Basics.Parameters
{
    internal class Program
    {
        // Outputparameter müssen NICHT initialisiert sein
        private static void BerechneLv(int alter, double vSumme, out int laufzeit, out double beitrag)
        {
            laufzeit = 65 - alter;
            beitrag = vSumme / laufzeit;
        }

        /// <summary>
        ///     Rahmenprogramm
        /// </summary>
        /// <param name="args"></param>
        private static void Main(string[] args)
        {
            int a = 100, b = 200;

            TauscheByValue(a, b);
            Console.WriteLine("nach TauscheByValue: a={0:d}, b={0:d}" + a + b);

            TauscheByRef(ref a, ref b);
            Console.WriteLine("nach TauscheByRef: a={0:d}, b={0:d}" + a + b);

            int laufzeit;
            double beitrag;
            BerechneLv(40, 100000, out laufzeit, out beitrag);
            Console.WriteLine("nach BerechneLV: Laufzeit, Beitrag" + laufzeit + beitrag);

            Console.ReadLine();
        }

        private static void TauscheByRef(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        private static void TauscheByValue(int x, int y) // Funktioniert nicht, da nur die Kopien getauscht werden
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
