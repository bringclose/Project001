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


            string test = "Nguyễn Việt Hùng, Lưu Anh Hùng, ồ ớ đừng, lệnh bắt";
            System.Console.WriteLine("Contents of WriteText.txt = {0}", Speaker.src.Text.sReplaceUTF8(test));

            test = Speaker.src.Text.sUpcase(test);
            System.Console.WriteLine("Contents of WriteText.txt = {0}", test);


            // create MyObjs containing key and string data
            /*
            MyObj obj1 = new MyObj(0001, "MyObj 1");
            MyObj obj2 = new MyObj(0002, "MyObj 2");
            MyObj obj3 = new MyObj(0003, "MyObj 3");
            MyObj obj4 = new MyObj(0004, "MyObj 4");
            MyObj obj5 = new MyObj(0005, "MyObj 5");
            MyObj obj6 = new MyObj(0006, "MyObj 6");
            MyObj obj7 = new MyObj(0007, "MyObj 7");
            MyObj obj8 = new MyObj(0008, "MyObj 8");
            MyObj obj9 = new MyObj(0009, "MyObj 9");
            MyObj obj10 = new MyObj(0010, "MyObj 10");
            MyObj obj11 = new MyObj(0011, "MyObj 11");
            MyObj obj12 = new MyObj(0012, "MyObj 12");
            MyObj obj13 = new MyObj(0013, "MyObj 13");

            try
            {
                // format: Add(key, value)
                redBlack.Add(new MyKey(obj1.Key), obj1);
                redBlack.Add(new MyKey(obj2.Key), obj2);
                redBlack.Add(new MyKey(obj3.Key), obj3);
                redBlack.Add(new MyKey(obj4.Key), obj4);
                redBlack.Add(new MyKey(obj5.Key), obj5);
                redBlack.Add(new MyKey(obj6.Key), obj6);
                redBlack.Add(new MyKey(obj7.Key), obj7);
                redBlack.Add(new MyKey(obj8.Key), obj8);
                redBlack.Add(new MyKey(obj9.Key), obj9);
                redBlack.Add(new MyKey(obj10.Key), obj10);
                redBlack.Add(new MyKey(obj11.Key), obj11);
                redBlack.Add(new MyKey(obj12.Key), obj12);
                redBlack.Add(new MyKey(obj13.Key), obj13);

                TraverseEnumerator();
                Console.WriteLine(Environment.NewLine);

                Console.WriteLine(Environment.NewLine);

                Console.WriteLine("- RedBlack Values -");
                RedBlackEnumerator t = redBlack.Values();
                while (t.MoveNext())
                    Console.WriteLine(((MyObj)(t.Value)).Data);
                Console.WriteLine(Environment.NewLine);

                Console.WriteLine("- RedBlack Keys -");
                RedBlackEnumerator k = redBlack.Keys();
                while (k.MoveNext())
                    Console.WriteLine(k.Key);
                Console.WriteLine(Environment.NewLine);

                DumpMinMaxValue();
                Console.WriteLine(Environment.NewLine);

                MyKey tObjKey = (MyKey)redBlack.GetMinKey();
                MyObj tObj = (MyObj)redBlack.GetData(tObjKey);
                Console.WriteLine("Remove Min Key: " + tObj.ToString());
                Console.WriteLine(Environment.NewLine);
                redBlack.Remove(tObjKey);
                DumpRedBlack(false);
                Console.WriteLine(Environment.NewLine);

                Console.WriteLine("Remove Max Value:" + redBlack.GetMaxValue().ToString());
                redBlack.RemoveMax();
                Console.WriteLine("Remove Min Value:" + redBlack.GetMinValue().ToString());
                redBlack.RemoveMin();
                Console.WriteLine(Environment.NewLine);

                DumpRedBlack(true);
                Console.WriteLine(Environment.NewLine);

                Console.WriteLine("Remove Min Key:" + ((MyKey)(redBlack.GetMinKey())).ToString());
                redBlack.RemoveMin();
                Console.WriteLine("Remove Max Key:" + ((MyKey)(redBlack.GetMaxKey())).ToString());
                redBlack.RemoveMax();
                Console.WriteLine(Environment.NewLine);

                DumpRedBlack(true);
                Console.WriteLine(Environment.NewLine);

                Console.WriteLine("** Clearing Tree **");
                redBlack.Clear();
                Console.WriteLine(Environment.NewLine);

                DumpRedBlack(false);

                Console.WriteLine("Press enter to terminate");
                //Console.ReadLine();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine("Press enter to terminate");
                Console.ReadLine();
            }
            */
            int i = 72;
            char c = Convert.ToChar(i);
            
            Console.WriteLine(c);
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
    }
}
