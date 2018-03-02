namespace ZbW.Math.TestFramework.Library.UnitTests
{
    using NUnit.Framework;

    [TestFixture]
    public class ExtendedOperationTests
    {
        [Test]
        public void Exponent_Calculate_ReturnsResult()
        {
            // arrange
            var extendedOperation = new ExtendedOperation();

            // act
            var result = extendedOperation.Exponent(2, 8);

            // assert
            Assert.That(result, Is.EqualTo(256));
        }

        [Test]
        public void Factorial_Calculate_ReturnsResult()
        {
            // arrange
            var extendedOperation = new ExtendedOperation();

            // act
            var result = extendedOperation.Factorial(4);

            // assert
            Assert.That(result, Is.EqualTo(24));
        }

        [Test]
        public void Modulo_Calculate_ReturnsResult()
        {
            // arrange
            var extendedOperation = new ExtendedOperation();

            // act
            var result = extendedOperation.Modulo(100, 7);

            // assert
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void Percentage_Calculate_ReturnsResult()
        {
            // arrange
            var extendedOperation = new ExtendedOperation();

            // act
            var result = extendedOperation.Percent(20, 80);

            // assert
            Assert.That(result, Is.EqualTo(16));
        }
    }
}