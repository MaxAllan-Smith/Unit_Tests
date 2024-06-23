using Unit_Tests;
using Xunit;

namespace Unit_Tests_Test
{
	public class CalculatorTests
	{
		[Fact]
		public void Add_TwoNumbers_ReturnsSum()
		{
			// Arrange
			var calculator = new Calculator();
			int num1 = 2;
			int num2 = 2;

			// Act
			int result = calculator.Add(num1, num2);

			// Assert
			Assert.Equal(4, result);
		}

		[Fact]
		public void Subtract_TwoNumbers_ReturnSum()
		{
			// Arrange
			var calculator = new Calculator();
			int num1 = 4;
			int num2 = 2;

			// Act
			int result = calculator.Subtract(num1, num2);

			// Assert
			Assert.Equal(2, result);
		}

		[Fact]
		public void Divide_TwoNumbers_ReturnsSum()
		{
			// Arrange
			var calculator = new Calculator();
			int num1 = 6;
			int num2 = 2;

			// Act
			int result = calculator.Divide(num1, num2);

			//Assert
			Assert.Equal(3, result);
		}
	}
}

