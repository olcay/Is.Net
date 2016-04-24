using System;

namespace Is.Net.Helpers
{
    public class NumericHelper
    {
        public static Lazy<NumericHelper> Instance = new Lazy<NumericHelper>(() => new NumericHelper());

        public bool IsInteger(string value)
        {
            var n = 0;
            var result = false;

            if (int.TryParse(value, out n))
            {
                result = true;
            }

            return result;
        }

        public bool IsInteger(decimal value)
        {
            return value == (int)value;
        }

        public bool IsEven(decimal value)
        {
            return value % 2 == 0;
        }

        public bool IsOdd(decimal value)
        {
            return Math.Abs(value) % 2 == 1;
        }

        public bool IsAbove(decimal value, decimal min)
        {
            return value > min;
        }

        public bool IsUnder(decimal value, decimal max)
        {
            return value < max;
        }

        public bool IsBetween(decimal value, decimal min, decimal max)
        {
            return value < max && value > min;
        }

        public bool IsFinite(double value)
        {
            return !double.IsNaN(value) && !double.IsInfinity(value);
        }
    }
}
