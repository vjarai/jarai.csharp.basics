using System;

namespace Jarai.Pattern.Singleton
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // var highlander = new Highlander();

            var highlander1 = Highlander.GetInstance();
            var highlander2 = Highlander.GetInstance();

            if (highlander1 != highlander2)
                Console.WriteLine("Es darf nur einen geben!!!");
            else
                Console.WriteLine("Alles ok.");
        }
    }
}
