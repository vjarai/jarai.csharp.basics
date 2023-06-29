namespace Jarai.CSharp.Calculator.Logic.Model
{
    public interface ICalculationService
    {
        double Add(double x, double y);
        double Divide(double x, double y);
        double Multiply(double factor1, double factor2);
        double Subtract(double x, double y);
    }
}
