using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Speaker.src
{
    class Utils
    {
        static string dataFile = @".\..\..\res\";
        
        public static string sReadingAllText()
        {
            return System.IO.File.ReadAllText(dataFile + @".\data.dat");
        }
    }
}
