namespace ZbW.Math.TestFramework.Library
{
    using System;

    public class ExtendedOperation
    {
        public int Percent(int percentage, int ofValue)
        {
            var result = percentage * ofValue / 100;
            return result;
        }

        public double Exponent(double baseValue, double power)
        {
            var result = Math.Pow(baseValue, power);
            return result;
        }

        public int Factorial(int shriek)
        {
            var result = 1;

            if (shriek > result)
            {
                for (var i = 1; i < shriek;)
                {
                    result = result * shriek;
                    shriek--;
                }
            }

            return result;
        }

        public int Modulo(int firstValue, int secondValue)
        {
            var result = firstValue % secondValue;
            return result;
        }
    }
}