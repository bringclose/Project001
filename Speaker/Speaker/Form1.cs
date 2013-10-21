using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using Speaker1;
using Speaker.src;
using RedBlackTree;
using System.Collections;


namespace Speaker
{
    public partial class Form1 : Form
    {
        static RedBlack redBlack = new RedBlack();

        public Form1()
        {
            InitializeComponent();
        }
        public static int TextToNumber(string text)
        {
            int sum = 0;
            foreach (char c in text)
            {
                sum = sum * 26 + c - 'A' + 1;
            }
            return sum;
        }

        public static string NumberToText(int Number)
        {
            return (Number - 1 + 'A').ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string stmp = Speaker.src.Utils.sReadingAllText();
            //System.Console.WriteLine("Contents of WriteText.txt = {0}", stmp);
            //_lblText.Text = stmp;
            //System.Console.WriteLine("Contents of WriteText.txt = {0}", _lblText.Text);
            //string stmp1 = Speaker.src.Text.sClearSpace(stmp);
            //_lblText2.Text = stmp1;
            //System.Console.WriteLine("Contents of WriteText.txt = {0}", stmp1);


            //string test = "Nguyễn Việt Hùng, Lưu Anh Hùng, ồ ớ đừng, lệnh bắt";
            //System.Console.WriteLine("Contents of WriteText.txt = {0}", Speaker.src.Text.sReplaceUTF8(test));

            //test = Speaker.src.Text.sUpcase(Speaker.src.Text.sReplaceUTF8(test));
            //System.Console.WriteLine("Contents of WriteText.txt = {0}", test);

            Hashtable hashtable = new Hashtable();
            //a
            hashtable.Add("_a", "a");
                hashtable.Add("_aa", "aa");
                    hashtable.Add("_aas", "aas");
                    hashtable.Add("_aaf", "aaf");
                    hashtable.Add("_aar", "aar");
                    hashtable.Add("_aax", "aax");
                    hashtable.Add("_aaj", "aaj");
                    hashtable.Add("_aac", "aac");
                    hashtable.Add("_aam", "aam");
                    hashtable.Add("_aan", "aan");
                    hashtable.Add("_aap", "aap");
                    hashtable.Add("_aau", "aau");
                    hashtable.Add("_aay", "aay");
                hashtable.Add("_aw", "aw");
                hashtable.Add("_as", "as");
                hashtable.Add("_af", "af");
                hashtable.Add("_ar", "ar");
                hashtable.Add("_ax", "ax");
                hashtable.Add("_aj", "aj");
                hashtable.Add("_ac", "ac");
                hashtable.Add("_ai", "ai");
                hashtable.Add("_am", "am");
                hashtable.Add("_an", "an");
                hashtable.Add("_ao", "ao");
                hashtable.Add("_ap", "ap");
                hashtable.Add("_at", "at");
                hashtable.Add("_au", "au");
                hashtable.Add("_ay", "ay");

            //TODO

            //t
            hashtable.Add("_t", "t");
                hashtable.Add("_th", "th");
                hashtable.Add("_tr", "tr");

            //foreach (string key in hashtable.Keys)
            //{
            //    System.Console.WriteLine("key = {0} - data = {1}", key, (string)hashtable[key]);
            //}
            List<string> list = new List<string>();
            list = GetListString(hashtable, "traam thaay");
            foreach (string value in list)
            {
                Console.WriteLine(value);
            }
            // create MyObjs containing key and string data
        }

        public static void DumpRedBlack(bool boolDesc)
        {
            // returns keys only
            RedBlackEnumerator k = redBlack.Keys(boolDesc);
            // returns data only, in this case, MyObjs
            RedBlackEnumerator e = redBlack.Elements(boolDesc);

            if (boolDesc)
                Console.WriteLine("** Dumping RedBlack: Ascending **");
            else
                Console.WriteLine("** Dumping RedBlack: Descending **");

            Console.WriteLine("RedBlack Size: " + redBlack.Size().ToString() + Environment.NewLine);

            Console.WriteLine("- keys -");
            while (k.HasMoreElements())
                Console.WriteLine(k.NextElement());

            Console.WriteLine("- my objects -");
            MyObj cmmMyObj;
            while (e.HasMoreElements())
            {
                cmmMyObj = ((MyObj)(e.NextElement()));
                Console.Write("Key:" + cmmMyObj.ToString());
                Console.WriteLine(" Data:" + cmmMyObj.Data);
            }

        }
        public static void TraverseEnumerator()
        {
            Console.WriteLine("** Traversing using Enumerator **");
            Console.WriteLine(Environment.NewLine);

            RedBlackEnumerator myEnumerator = redBlack.GetEnumerator();

            while (myEnumerator.MoveNext())
                Console.WriteLine("Key:{0}\t" + "  Data:{1}\t" + " Color:{2}\t" + " Parent Key:{3}",
                    myEnumerator.Key, ((MyObj)myEnumerator.Value).Data, myEnumerator.Color, myEnumerator.parentKey);

        }
        public static void DumpMinMaxValue()
        {
            Console.WriteLine("** Dumping Min/Max Values  **");
            Console.WriteLine("Min MyObj value: " + ((MyObj)redBlack.GetMinValue()).Data);
            Console.WriteLine("Max MyObj value: " + ((MyObj)redBlack.GetMaxValue()).Data);
            Console.WriteLine("Min MyObj key: " + ((MyKey)redBlack.GetMinKey()).ToString());
            Console.WriteLine("Max MyObj key: " + ((MyKey)redBlack.GetMaxKey()).ToString());
        }

        public static List<string> GetListString(Hashtable hashtable, string sText)
        {
            List<string> list = new List<string>();

            int iLeng = sText.Length;
            int iCount = 0;
            string sReturn = "";
            string sReturn1 = "";
            for (int i = 0; i < iLeng; i++)
            {
                if (sText[i] >= 'a' && sText[i] <= 'z')
                {
                    sReturn1 = sReturn1 + sText[i];
                    iCount = 0;
                    foreach (string key in hashtable.Keys)
                    {
                        if (sReturn1 == (string)hashtable[key])
                        {
                            sReturn = key;
                            break;
                        }
                        iCount++;
                        if (iCount >= hashtable.Count)
                        {
                            list.Add(sReturn);
                            sReturn = "";
                            sReturn1 = "";
                            i--;
                        }
                    }
                    if (i >= iLeng - 1)
                    {
                        list.Add(sReturn);
                    }
                }
                else
                { 
                    //TODO
                }
            }
            return list;
            //list.Add("New York");
            //list.Add("Mumbai");
            //list.Add("Berlin");
            //list.Add("Istanbul");
            //list.Reverse();
            //foreach (string value in list)
            //{
            //    Console.WriteLine(value);
            //}
        }

    }
}
