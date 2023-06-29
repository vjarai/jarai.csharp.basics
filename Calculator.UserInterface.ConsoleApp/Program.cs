using Jarai.CSharp.Calculator.Logic.Model;

namespace Jarai.CSharp.Calculator.UserInterface.ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Erste Zahl?");
            string eingabe = Console.ReadLine();
            var zahl1 = double.Parse(eingabe);

            Console.WriteLine("Zweite Zahl?");
            eingabe = Console.ReadLine();
            var zahl2 = double.Parse(eingabe);

            var calculator = new CalculationService();
            double ergebnis = calculator.Add(zahl1, zahl2);

            Console.WriteLine($"Ergebnis: {zahl1} + {zahl2} = {ergebnis}");

        }
    }
}
