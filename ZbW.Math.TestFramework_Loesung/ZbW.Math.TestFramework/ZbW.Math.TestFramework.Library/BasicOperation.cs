namespace ZbW.Math.TestFramework.Library
{
    public class BasicOperation
    {
        public int Addition(int firstAddend, int secondAddend)
        {
            var sum = firstAddend + secondAddend;
            return sum;
        }

        public int Subtraction(int minuend, int subtrahend)
        {
            var difference = minuend - subtrahend;
            return difference;
        }

        public double Division(int dividend, int divisor)
        {
            if (divisor == 0)
            {
                throw new ZeroDivisorNotAllowedException();
            }

            var quotient = (double)dividend / divisor;
            return quotient;
        }

        public int Multiplication(int multiplier, int multiplicand)
        {
            var product = multiplier * multiplicand;
            return product;
        }
    }
}