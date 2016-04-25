using Is.Net.Helpers;

namespace Is.Net
{
    public static class Is
    {
        #region Numeric
        public static bool Integer(decimal value)
        {
            return NumericHelper.Instance.Value.IsInteger(value);
        }

        public static bool Integer(string value)
        {
            return NumericHelper.Instance.Value.IsInteger(value);
        }

        public static bool Even(decimal value)
        {
            return NumericHelper.Instance.Value.IsEven(value);
        }

        public static bool Odd(decimal value)
        {
            return NumericHelper.Instance.Value.IsOdd(value);
        }

        public static bool Positive(decimal value)
        {
            return NumericHelper.Instance.Value.IsAbove(value, 0);
        }

        public static bool Negative(decimal value)
        {
            return NumericHelper.Instance.Value.IsUnder(value, 0);
        }

        public static bool Above(decimal value, decimal min)
        {
            return NumericHelper.Instance.Value.IsAbove(value, min);
        }

        public static bool Under(decimal value, decimal max)
        {
            return NumericHelper.Instance.Value.IsUnder(value, max);
        }

        public static bool Between(decimal value, decimal min, decimal max)
        {
            return NumericHelper.Instance.Value.IsBetween(value, min, max);
        }

        public static bool Finite(double value)
        {
            return NumericHelper.Instance.Value.IsFinite(value);
        }
        #endregion

        #region Text
        public static bool Space(string value)
        {
            return TextHelper.Instance.Value.IsSpace(value);
        }

        public static bool Space(char value)
        {
            return TextHelper.Instance.Value.IsSpace(value);
        }

        public static bool URL(string value)
        {
            return TextHelper.Instance.Value.IsURL(value);
        }

        public static bool Email(string value)
        {
            return TextHelper.Instance.Value.IsEmail(value);
        }

        public static bool Name(string value, int limit = 40)
        {
            return TextHelper.Instance.Value.IsName(value, limit);
        }

        public static bool TurkishIdentity(string value)
        {
            return TextHelper.Instance.Value.IsTurkishIdentity(value);
        }

        public static bool Confirmation(string value)
        {
            return TextHelper.Instance.Value.IsConfirmation(value);
        }

        public static bool SocialSecurityNumber(string value)
        {
            return TextHelper.Instance.Value.IsSocialSecurityNumber(value);
        }

        public static bool IP(string value)
        {
            return TextHelper.Instance.Value.IsIP(value);
        }

        public static bool CreditCard(string value)
        {
            return TextHelper.Instance.Value.IsCreditCard(value);
        }

        public static bool AlphaNumeric(string value)
        {
            return TextHelper.Instance.Value.IsAlphaNumeric(value);
        }
        #endregion
    }
}
