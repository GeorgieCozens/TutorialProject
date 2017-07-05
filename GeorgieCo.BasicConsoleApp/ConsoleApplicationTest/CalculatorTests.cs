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

        // implement a test for every method and ensure they all pass by right clicking and selecting run
    }
}
