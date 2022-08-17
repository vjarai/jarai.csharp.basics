using System;

namespace Jarai.Calculator.Logic
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var t = new CalculationService();

            t.Operand1 = "100";
            t.Operand2 = "200";
            t.Addiere();

            Console.WriteLine(t.Ergebnis);
        }
    }
}
