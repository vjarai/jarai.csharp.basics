using Xunit;

namespace Jarai.Calculator.Logic.Tests
{
    public class CalculationServiceTests
    {
        [Fact]
        public void MultiplyTest()
        {
            var target = new CalculationService();

            double actual = target.Multiply(10, 20);

            Assert.Equal(200, actual);
        }
    }
}
