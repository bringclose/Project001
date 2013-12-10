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

                                , 'ý', 'ỳ', 'ỷ', 'ỹ', 'ỵ'

                                , 'đ'

                                , 'Á', 'À', 'Ả', 'Ã', 'Ạ'
                                , 'Â', 'Ă'
                                , 'Ấ', 'Ầ', 'Ẩ', 'Ẫ', 'Ậ'
                                , 'Ắ', 'Ằ', 'Ẳ', 'Ẵ', 'Ặ'

                                , 'É', 'È', 'Ẻ', 'Ẽ', 'Ẹ'
                                , 'Ê'
                                , 'Ế', 'Ề', 'Ể', 'Ễ', 'Ệ'

                                , 'Ú', 'Ù', 'Ủ', 'Ũ', 'Ụ'
                                , 'Ư'
                                , 'Ứ', 'Ừ', 'Ử', 'Ữ', 'Ự'

                                , 'Í', 'Ì', 'Ỉ', 'Ĩ', 'Ị'

                                , 'Ó', 'Ò', 'Ỏ', 'Õ', 'Ọ'
                                , 'Ô', 'Ơ'
                                , 'Ố', 'Ồ', 'Ổ', 'Ỗ', 'Ộ'
                                , 'Ớ', 'Ờ', 'Ở', 'Ỡ', 'Ợ'

                                , 'Ý', 'Ỳ', 'Ỷ', 'Ỹ', 'Ỵ'

                                , 'Đ'
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

                                , "ys", "yf", "yr", "yx", "yj"

                                , "dd"

                                , "AS", "AF", "AR", "AX", "AJ"
                                , "AA", "AW"
                                , "AAS", "AAF", "AAR", "AAX", "AAJ"
                                , "AWS", "AWF", "AWR", "AWX", "AWJ"

                                , "ES", "EF", "ER", "EX", "EJ"
                                , "EE"
                                , "EES", "EEF", "EER", "EEX", "EEJ"

                                , "US", "UF", "UR", "UX", "UJ"
                                , "UW"
                                , "UWS", "UWF", "UWR", "UWX", "UWJ"

                                , "IS", "IF", "IR", "IX", "IJ"

                                , "OS", "OF", "OR", "OX", "OJ"
                                , "OO", "OW"
                                , "OOS", "OOF", "OOR", "OOX", "OOJ"
                                , "OWS", "OWF", "OWR", "OWX", "OWJ"

                                , "YS", "YF", "YR", "YX", "YJ"

                                , "DD"
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
                    for (int j = 0; i < 10; j++)
                    {
                        if (j == 1)
                            break;
                    }
                }
                else
                {
                    sReturn = sReturn + sText[i];
                }
                //Console.WriteLine("Max MyObj key: ");
            }
            return sReturn;/*sText.ToLower();*/
        }

        public static List<string> GetListString(string sText)
        {
            List<string> list = new List<string>();

            int iLeng = sText.Length;
            string sReturn = "";
            for (int i = 0; i < iLeng; i++)
            {
                if (sText[i] == ' ' || sText[i] == '.' || sText[i] == ',' || sText[i] == '!' || sText[i] == '?')
                {
                    if (sText[i] == ' ' && sReturn != "")
                    {
                        list.Add(sReturn);
                        sReturn = "";
                    }
                    else if (sText[i] == '.')
                    {
                        list.Add(sReturn);
                        sReturn = "";
                        list.Add(".");
                    }
                    else if (sText[i] == ',')
                    {
                        list.Add(sReturn);
                        sReturn = "";
                        list.Add(",");
                    }
                    else if (sText[i] == '!')
                    {
                        list.Add(sReturn);
                        sReturn = "";
                        list.Add("!");
                    }
                    else if (sText[i] == '?')
                    {
                        list.Add(sReturn);
                        sReturn = "";
                        list.Add("?");
                    }
                    else
                    {
                        continue;
                    }
                }
                else
                {
                    if (i == iLeng - 1)
                    {
                        sReturn = sReturn + sText[i];
                        list.Add(sReturn);
                        return list;
                    }
                    else
                    {
                        sReturn = sReturn + sText[i];
                    }
                }
            }
            return list;
        }

        public static int CheckTextSD(string sText)
        {
            if (sText == ",")
            {
                return 3;
            }
            else if (sText == ".")
            {
                return 4;
            }
            else if (sText == "!")
            {
                return 5;
            }
            else if (sText == ".")
            {
                return 6;
            }
            else
            {
                if (sText[0] == 'a'
                    || sText[0] == 'e'
                    || sText[0] == 'o'
                    || sText[0] == 'u'
                    || sText[0] == 'y'
                    || sText[0] == 'i')
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        public static string GetFirstText(string sText)
        {
            string sReturn = "";
            int iLeng = sText.Length;

            for (int i = 0; i < iLeng; i++)
            {
                if (sText[i] == 'a'
                    || sText[i] == 'e'
                    || sText[i] == 'o'
                    || sText[i] == 'u'
                    || sText[i] == 'y'
                    || sText[i] == 'i')
                {
                    if (    (i > 0)
                            && ((sText[i - 1] == 'q' && sText[i] == 'u')
                            || (sText[i - 1] == 'g' && sText[i] == 'i')))
                    {
                        sReturn = sReturn + sText[i];
                    }
                    break;
                }
                else
                {
                    sReturn = sReturn + sText[i];
                }
            }
            return sReturn;
        }

        public static string GetSecondText(string sText)
        {
            string sReplace = "";
            if (CheckTextSD(sText) == 1)
            {
                return sText;
            }
            else
            {
                if (GetFirstText(sText) == "gi")
                {
                    sReplace = "g";
                }
                //else if (GetFirstText(sText) == "qu")
                //{
                //    sReplace = "q";
                //}
                else
                { 
                    sReplace = GetFirstText(sText);
                }
                return sText.Replace(sReplace, "");
            }
        }
    }
}
