using System;

namespace Jarai.CSharp.Basics.Parameters
{
    internal class Program
    {
        /// <summary>
        ///     Rahmenprogramm
        /// </summary>
        private static void Main(string[] args)
        {
            int a = 100, b = 200;

            TauscheByValue(a, b); 
            Console.WriteLine($"nach TauscheByValue: a={a}, b={b}");

            TauscheByRef(ref a, ref b);
            Console.WriteLine($"nach TauscheByRef: a={a}, b={b}");

           Console.ReadLine();
        }

        /// <summary>
        ///  Funktioniert nicht, da x und y Kopien von a und b sind ("call by value") und nur diese Kopien getauscht werden
        /// </summary>
        private static void TauscheByValue(int x, int y) // Input Parameter
        {
            int temp = x;
            x = y;
            y = temp;
        }

        /// <summary>
        /// Kann (wegen ref!) auf die Variablen a und b in Main zugreifen
        /// </summary>
        private static void TauscheByRef(ref int x, ref int y) // Outputparameter immer mit ref
        {
            int temp = x;
            x = y;
            y = temp;
        }
    }
}
