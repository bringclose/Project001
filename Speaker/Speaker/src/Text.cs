using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
            string sTmp = sText.Trim();
            return sTmp;
        }
    }
}
