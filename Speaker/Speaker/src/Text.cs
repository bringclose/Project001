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

        public static string TrimWhitespaceAnd(string sText, params char[] characters)
        {
            int start = 0;
            while (start < sText.Length)
            {
                if (!char.IsWhiteSpace(sText[start]) &&
                        !characters.Contains(sText[start]))
                {
                    break;
                }
                start++;
            }
            int end = sText.Length - 1;
            while (end >= start)
            {
                if (!char.IsWhiteSpace(sText[end]) &&
                        !characters.Contains(sText[end]))
                {
                    break;
                }
                end--;
            }
            int length = (end - start) + 1;
            if (length == sText.Length)
            {
                return sText;
            }
            if (length == 0)
            {
                return string.Empty;
            }
            return sText.Substring(start, length);
        }

        public static string sReplaceUTF8(string sText)
        {
            char[] cAccents = {   'á', 'à', 'ả', 'ã', 'ạ'
                                , 'â', 'ă'
                                , 'ấ', 'ầ', 'ẩ', 'ẫ', 'ậ'
                                , 'ắ', 'ằ', 'ẳ', 'ẵ', 'ặ'

                                , 'é', 'è', 'ẻ', 'ẽ', 'ẹ'
                                , 'ê'
                                , 'ế', 'ề', 'ể', 'ễ', 'ệ'

                                , 'ú', 'ù', 'ủ', 'ũ', 'ụ'
                                , 'ư'
                                , 'ứ', 'ừ', 'ử', 'ữ', 'ự'

                                , 'í', 'ì', 'ỉ', 'ĩ', 'ị'

                                , 'ó', 'ò', 'ỏ', 'õ', 'ọ'
                                , 'ô', 'ơ'
                                , 'ố', 'ồ', 'ổ', 'ỗ', 'ộ'
                                , 'ớ', 'ờ', 'ở', 'ỡ', 'ợ'

                                , 'đ'
                             };

            string[] cReplace = {   "as", "af", "ar", "ax", "aj"
                                , "aa", "aw"
                                , "aas", "aaf", "aar", "aax", "aaj"
                                , "aws", "awf", "awr", "awx", "awj"

                                , "es", "ef", "er", "ex", "ej"
                                , "ee"
                                , "ees", "eef", "eer", "eex", "eej"

                                , "us", "uf", "ur", "ux", "uj"
                                , "uw"
                                , "uws", "uwf", "uwr", "uwx", "uwj"

                                , "is", "if", "ir", "ix", "ij"

                                , "os", "of", "or", "ox", "oj"
                                , "oo", "ow"
                                , "oos", "oof", "oor", "oox", "ooj"
                                , "ows", "owf", "owr", "owx", "owj"

                                , "dd"
                             };
            for (int i = 0; i < cAccents.Length; i++)
            {
                sText = sText.Replace(cAccents[i].ToString(), cReplace[i]);
            }
            return sText;
        }

        public static string sUpcase(string sText)
        {
            int iLeng = sText.Length;
            string sReturn = "";
            for (int i = 0; i < iLeng; i++)
            {
                if (sText[i] >= 'A' && sText[i] <= 'Z')
                {
                    char c = Convert.ToChar((sText[i] + 32));
                    sReturn = sReturn + c;
                }
                else
                {
                    sReturn = sReturn + sText[i];
                }
            }
            return sReturn;/*sText.ToLower();*/
        }
    }
}
