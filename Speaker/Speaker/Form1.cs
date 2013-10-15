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


namespace Speaker
{
    public partial class Form1 : Form
    {
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
            string stmp = Speaker.src.Utils.sReadingAllText();
            System.Console.WriteLine("Contents of WriteText.txt = {0}", stmp);
            _lblText.Text = stmp;
            System.Console.WriteLine("Contents of WriteText.txt = {0}", _lblText.Text);
            string stmp1 = Speaker.src.Text.sClearSpace(stmp);
            _lblText2.Text = stmp1;
            System.Console.WriteLine("Contents of WriteText.txt = {0}", stmp1);


            string test = "Nguyễn Việt Hùng, Lưu Anh Hùng, ồ ớ đừng, lệnh bắt";
            System.Console.WriteLine("Contents of WriteText.txt = {0}", Speaker.src.Text.sReplaceUTF8(test));
        }
    }
}
