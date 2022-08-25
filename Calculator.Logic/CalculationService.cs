namespace Jarai.Calculator.Logic
{
    public class CalculationService
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Divide(double x, double y)
        {
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
