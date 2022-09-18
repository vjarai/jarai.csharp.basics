using System;

namespace Jarai.CSharp.Pattern.Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Geht nicht (wg. privatem Konstruktor)
            // var präsident = new Präsident();  

            var präsident1 = Präsident.GetInstance();
            var präsident2 = Präsident.GetInstance();

            if (präsident1 != präsident2)
                Console.WriteLine("Es darf nur einen geben!!!");
            else
                Console.WriteLine("Alles ok, es ist immer derselbe :-)");
        }
    }
}
