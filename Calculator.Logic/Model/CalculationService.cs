using System;

namespace Jarai.CSharp.Calculator.Logic.Model
{
    public class CalculationService : ICalculationService
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Divide(double x, double y)
        {
            if (y == 0)
                throw new InvalidOperationException("Division durch 0 ist nicht möglich.");

            return x / y;
        }

        public double Multiply(double factor1, double factor2)
        {
            return factor1 * factor2;
        }

        public double Subtract(double x, double y)
        {
            return x - y;
        }
    }
}
