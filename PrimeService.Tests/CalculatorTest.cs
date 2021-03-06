using PrimeService;
using Xunit;

namespace PrimeService.Tests
{
    public class CalculatorTest
    {
        [Theory]
        [InlineData(4, 3, 7)]
        [InlineData(21, 5.25, 26.25)]
        public void Add_SimpleValuesShouldCalculate(double x, double y, double expected)
        {
            // Arrange
            //Act
            double actual = Calculator.Add(x, y);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Theory]
        [InlineData(8, 4, 2)]
        public void Divide_SimpleValuesShouldCalcuate(double x, double y, double expected)
        {
            double actual = Calculator.Divide(x, y);
            Assert.Equal(expected, actual);

        }
        [Fact]
        public void Divide_DivideByZero()
        {
            double expected = 0;
            double actual = Calculator.Divide(15, 0);
            Assert.Equal(expected, actual);

        }
    }
}