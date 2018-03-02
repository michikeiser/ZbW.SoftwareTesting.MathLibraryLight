namespace ZbW.Math.TestFramework.Library.UnitTests
{
    using NUnit.Framework;

    [TestFixture]
    public class BasicOperationTests
    {
        [Test]
        public void Addition_Calculate_ReturnsSum()
        {
            // arrange
            var basicOperation = new BasicOperation();

            // act
            var result = basicOperation.Addition(2, 3);

            // assert
            Assert.That(result, Is.EqualTo(5));
        }

        [Test]
        public void Division_Calculate_ReturnsQuotient()
        {
            // arrange
            var basicOperation = new BasicOperation();

            // act
            var result = basicOperation.Division(100, 5);

            // assert
            Assert.That(result, Is.EqualTo(20));
        }

        [Test]
        public void DivisionByZero_Calculate_ReturnsException()
        {
            // arrange
            var basicOperation = new BasicOperation();

            // act
            void Calculation() => basicOperation.Division(100, 0);

            // assert
            Assert.Throws<ZeroDivisorNotAllowedException>(Calculation, "Die Exception wird nicht ausgelöst!");
        }

        [Test]
        public void Multiplication_Calculate_ReturnsProduct()
        {
            // arrange
            var basicOperation = new BasicOperation();

            // act
            var result = basicOperation.Multiplication(100, 3);

            // assert
            Assert.That(result, Is.EqualTo(300));
        }

        [Test]
        public void Subtraction_Calculate_ReturnsDifference()
        {
            // arrange
            var basicOperation = new BasicOperation();

            // act
            var result = basicOperation.Subtraction(20, 5);

            // assert
            Assert.That(result, Is.EqualTo(15));
        }
    }
}