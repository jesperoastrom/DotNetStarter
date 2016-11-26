using Xunit;

namespace App.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void CalculatorCanAdd()
        {
            var calculator = new Calculator();
            Assert.Equal(2, calculator.Add(1, 1));
        }
    }
}
