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
using System.Collections;
using System.IO;


namespace Speaker
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            txtInPut.Text = "Trường Tôn Đức Thắng, Tôn Đức Thắng. Tôn Đức Thắng! buồn ngủ quá tụi mày ơi";
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


            string test = "Nguyễn Việt Hùng, Lưu Anh Hùng, ồ     ớ đừng, lệnh bắt! ";
            System.Console.WriteLine("Contents of WriteText.txt = {0}", Speaker.src.Text.sReplaceUTF8(test));

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

            test = Speaker.src.Text.sReplaceUTF8(Speaker.src.Text.sUpcase(test));
            list = Speaker.src.Text.GetListString(test);
            foreach (string value in list)
            {
                Console.WriteLine(value);
            }
            
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
                    sReturn = sReturn + sText[i];
                }
            }
            return list;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int duration = 300;
            int overlap = 0;

            //WaveLib.WavePlayer player = new WaveLib.WavePlayer();
            //WaveLib.WaveData data = new WaveLib.WaveData(2, duration, overlap, "media\\tr.wav", "media\\uwowfng.wav");
            //player.playWave(data);
            //player.CloseFile();

            //WaveLib.WavePlayer player1 = new WaveLib.WavePlayer();
            //WaveLib.WaveData data1 = new WaveLib.WaveData(2, duration, overlap, "media\\h.wav", "media\\ojc.wav");
            //player1.playWave(data1);
            //player1.CloseFile();

            //WaveLib.WavePlayer player2 = new WaveLib.WavePlayer();
            //WaveLib.WaveData data2 = new WaveLib.WaveData(2, duration, overlap, "media\\t.wav", "media\\oon.wav");
            //player2.playWave(data2);
            //player2.CloseFile();

            //WaveLib.WavePlayer player3 = new WaveLib.WavePlayer();
            //WaveLib.WaveData data3 = new WaveLib.WaveData(2, duration, overlap, "media\\dd.wav", "media\\uwsc.wav");
            //player3.playWave(data3);
            //player3.CloseFile();

            //WaveLib.WavePlayer player4 = new WaveLib.WavePlayer();
            //WaveLib.WaveData data4 = new WaveLib.WaveData(2, duration, overlap, "media\\th.wav", "media\\awsng.wav");
            //player4.playWave(data4);
            //player4.CloseFile();

            Console.WriteLine("-----------");
            //string test = "kh";
            //string test1 = Speaker.src.Text.GetFirstText(test);
            //Console.WriteLine("-----------1");
            //Console.WriteLine(test1);
            //string test2 = Speaker.src.Text.GetSecondText(test);
            //Console.WriteLine("-----------2");
            //Console.WriteLine(test2);
            WaveLib.WavePlayer player = new WaveLib.WavePlayer();
            WaveLib.WaveData data = new WaveLib.WaveData(2, duration, overlap, "media\\tr.wav", "media\\uwowfng.wav");

            List<string> list = new List<string>();
            string testk = "Trường Tôn Đức Thắng, Tôn Đức Thắng. Tôn Đức Thắng! buồn ngủ quá tụi mày ơi";
            testk = txtInPut.Text;
            testk = Speaker.src.Text.sUpcase(Speaker.src.Text.sReplaceUTF8(testk));
            list = Speaker.src.Text.GetListString(testk);
            foreach (string value in list)
            {
                Console.WriteLine(value);
                string sFirst = "test\\" + Speaker.src.Text.GetFirstText(value) + ".wav";
                string sSecond = "test\\" + Speaker.src.Text.GetSecondText(value) + ".wav";
                Console.WriteLine("----------sFirst" + File.Exists(sFirst));
                Console.WriteLine("----------sSecond" + File.Exists(sSecond));
                if (Speaker.src.Text.CheckTextSD(value) == 1)
                {
                    data.SetData(1, duration, overlap, sSecond, "");
                }
                else if (Speaker.src.Text.CheckTextSD(value) == 2)
                {
                    data.SetData(2, duration, overlap, sFirst, sSecond);
                }
                else if (Speaker.src.Text.CheckTextSD(value) == 3)
                {
                    data.SetData(0, 300, overlap, "", "");
                }
                else if (Speaker.src.Text.CheckTextSD(value) == 4)
                {
                    data.SetData(0, 400, overlap, "", "");
                }
                else if (Speaker.src.Text.CheckTextSD(value) == 5)
                {
                    data.SetData(0, 400, overlap, "", "");
                }
                else
                {
                    data.SetData(0, 400, overlap, "", "");
                }

                player.playWave(data);
                player.CloseFile();
            }
            
        }

    }
}
