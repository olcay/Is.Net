using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Is.Net.Helpers
{
    public class TextHelper
    {
        public static Lazy<TextHelper> Instance = new Lazy<TextHelper>(() => new TextHelper());

        #region PrivateMethods
        private bool RegexMatch(string value, string pattern)
        {
            if (string.IsNullOrEmpty(value))
            {
                //TODO we can throw exception here
                return false;
            }

            Regex reg = new Regex(pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            return reg.IsMatch(value);
        }
        #endregion

        public bool IsSpace(string value)
        {
            return value == " ";
        }

        public bool IsSpace(char value)
        {
            return value == ' ';
        }

        public bool IsURL(string value)
        {
            return RegexMatch(value, @"^(ht|f)tp(s?)\:\/\/[0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*(:(0-9)*)*(\/?)([a-zA-Z0-9\-\.\?\,\'\/\\\+&amp;%\$#_]*)?$");
        }

        public bool IsEmail(string value)
        {
            return RegexMatch(value, @"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
        }

        public bool IsName(string value, int limit = 40)
        {
            //TODO do we need turkish characters or this method
            return RegexMatch(value, @"^[a-zA-Z''-'\s]{1," + limit + "}$");
        }

        public bool IsTurkishIdentity(string value)
        {
            bool result = false;
            if (!string.IsNullOrEmpty(value) && value.Length == 11)
            {
                long ATCNO, BTCNO, identity;
                long C1, C2, C3, C4, C5, C6, C7, C8, C9, Q1, Q2;

                identity = long.Parse(value);

                ATCNO = identity / 100;
                BTCNO = identity / 100;

                C1 = ATCNO % 10; ATCNO = ATCNO / 10;
                C2 = ATCNO % 10; ATCNO = ATCNO / 10;
                C3 = ATCNO % 10; ATCNO = ATCNO / 10;
                C4 = ATCNO % 10; ATCNO = ATCNO / 10;
                C5 = ATCNO % 10; ATCNO = ATCNO / 10;
                C6 = ATCNO % 10; ATCNO = ATCNO / 10;
                C7 = ATCNO % 10; ATCNO = ATCNO / 10;
                C8 = ATCNO % 10; ATCNO = ATCNO / 10;
                C9 = ATCNO % 10; ATCNO = ATCNO / 10;
                Q1 = ((10 - ((((C1 + C3 + C5 + C7 + C9) * 3) + (C2 + C4 + C6 + C8)) % 10)) % 10);
                Q2 = ((10 - (((((C2 + C4 + C6 + C8) + Q1) * 3) + (C1 + C3 + C5 + C7 + C9)) % 10)) % 10);

                result = ((BTCNO * 100) + (Q1 * 10) + Q2 == identity);
            }

            return result;
        }

        public bool IsConfirmation(string value)
        {
            List<string> words = new List<string> {
                "true", "evet", "e", "ok", "okay", "yes", "y", "si", "oui", "ja", "sim", "ken", "sea", "jes", "hai", "ndiyo", "gee", "ano", "igen", "da"
            };

            return words.Contains(value.ToLowerInvariant());
        }
    }
}
