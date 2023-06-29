using Jarai.CSharp.Calculator.Logic.Model;
using Xunit;

namespace Calculator.Logic.Tests
{
    public class CalculationServiceTests
    {
        [Fact]
        public void CanAdd()
        {
            // Arrange
            var target = new CalculationService();

            // Act
            double actual = target.Add(10, 20);

            // Assert
            Assert.Equal(30, actual);
        }

        [Fact]
        public void CanDivide()
        {
            // Arrange
            var target = new CalculationService();

            // Act
            double actual = target.Divide(10, 20);

            // Assert
            Assert.Equal(.5, actual);
        }

        [Fact]
        public void CanNotDivideByZero()
        {
            // Arrange
            var target = new CalculationService();

            // Act & Assert
            Assert.Throws<InvalidOperationException>( () => target.Divide(10, 0));

        }

        [Fact]
        public void CanMultiply()
        {
            // Arrange
            var target = new CalculationService();

            // Act
            double actual = target.Multiply(10, 20);

            // Assert
            Assert.Equal(200, actual);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(100, 1, 99)]
        public void CanSubtract(int value1, int value2, int expected)
        {
            // Arrange
            var target = new CalculationService();

            // Act
            double actual = target.Subtract(value1, value2);

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
