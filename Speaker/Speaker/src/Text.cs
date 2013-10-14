using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace Speaker.src
{
    class Text
    {
        public static string sClearAllSpace(string sText)
        {
            string sTmp = sText.Replace(" ", string.Empty);
            return sTmp;
        }

        public static string sClearSpace(string sText)
        {
            return Regex.Replace(sText, @"\s+", " ").Trim();
        }

        public static string TrimWhitespaceAnd(string inputString, params char[] characters)
        {
            int start = 0;
            while (start < inputString.Length)
            {
                if (!char.IsWhiteSpace(inputString[start]) &&
                        !characters.Contains(inputString[start]))
                {
                    break;
                }
                start++;
            }
            int end = inputString.Length - 1;
            while (end >= start)
            {
                if (!char.IsWhiteSpace(inputString[end]) &&
                        !characters.Contains(inputString[end]))
                {
                    break;
                }
                end--;
            }
            int length = (end - start) + 1;
            if (length == inputString.Length)
            {
                return inputString;
            }
            if (length == 0)
            {
                return string.Empty;
            }
            return inputString.Substring(start, length);
        }
    }
}
