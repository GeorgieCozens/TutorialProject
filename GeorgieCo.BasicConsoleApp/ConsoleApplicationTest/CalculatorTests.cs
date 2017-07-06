using com.georgieco.ConsoleApplication;
using NUnit.Framework;

namespace ConsoleApplicationTest
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void TestsTwoNumbersAddTogetherCorrectly()
        {
            // Arrange
            var sut = new Calculator();
            // Act
            var result = sut.Add(1, 2);
            // Assert
            Assert.AreEqual(3, result);
        }

        [Test]
        public void TestsNegativeFactorialReturnsError()
        {
            // Arange
            var sut = new Calculator();
            // Act
            var result = sut.Factorial(-2);
            // Assert
            Assert.AreEqual(0, result);
        }

        [Test]

        public void TestsFactorialFunction()
        {
            // Arrange
            var sut = new Calculator();
            // Act
            var result = sut.Factorial(6);
            // Assert
            Assert.AreEqual(720, result);
        }
    }
}
