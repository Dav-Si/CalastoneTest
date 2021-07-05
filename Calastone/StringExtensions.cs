using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Calastone
{
    public static class StringExtensions
    {
        private static readonly char[] vowels = { 'a', 'e', 'i', 'o', 'u' };

        public static bool IsValidLength(string s, int length)
        {
            return s.Length > length;
        }

        public static bool ContainsChar(string s, char c)
        {
            return !s.Contains(c);
        }

        public static string GetMiddleChars(string s)
        {
            int length = s.Length;
            int middleIndex = ((int)Math.Ceiling(((double)length) / 2)) - 1;
            int lengthOfMiddle = length % 2 == 0 ? 2 : 1;
            return s.Substring(middleIndex, lengthOfMiddle);
        }

        public static bool IsValid(this string s)
        {
            return IsValidLength(s, 3) &&
                   ContainsChar(s, 't') &&
                   !GetMiddleChars(s).Any(x => vowels.Contains(x));
        }
    }
}
