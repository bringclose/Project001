
//ReadFromFile
namespace Speaker1
{
    class ReadFromFile
    {
        static string dataFile = @".\..\..\res\";
        public static void ReadingText()
        {
            string text = System.IO.File.ReadAllText(dataFile + @".\data.dat");
            System.Console.WriteLine("Contents of WriteText.txt = {0} - {0}", text, text);
        }

        public static string sReadingText()
        {
            return System.IO.File.ReadAllText(dataFile + @".\data.dat");
        }
        /*private byte[] DiphConcat(string word, string lpszF1, string lpszF2, ref int sampnum)
        {
            string DataPath = Application.StartupPath + @"\tên thư mục dữ liệu\";
            string File1Pim, File2Pim, File1Wav, File2Wav;
            int s1, e1, s2, e2;
            File1Pim = DataPath + "_" + lpszF1 + ".pim";
            File2Pim = DataPath + lpszF2 + ".pim";

            File1Wav = DataPath + "_" + lpszF1 + ".wav";
            File2Wav = DataPath + lpszF2 + ".wav";

            FileStream fs = new FileStream(File1Pim, FileMode.Open);
            BinaryReader f = new BinaryReader(fs);
            s1 = f.ReadInt16();
            e1 = f.ReadInt16();
            f.Close();

            fs = new FileStream(File2Pim, FileMode.Open);
            f = new BinaryReader(fs);
            s2 = f.ReadInt16();
            e2 = f.ReadInt16();
            f.Close();
            fs = new FileStream(File1Wav, FileMode.Open, FileAccess.Read);
            int num1 = (int)fs.Length - 44;
            fs = new FileStream(@File1Wav, FileMode.Open, FileAccess.Read);
            byte[] buf1 = new byte[fs.Length - 44];
            fs.Position = 44;
            fs.Read(buf1, 0, buf1.Length);
            fs.Close();
            fs = new FileStream(File2Wav, FileMode.Open, FileAccess.Read);
            int num2 = (int)fs.Length - 44;

            fs = new FileStream(@File2Wav, FileMode.Open, FileAccess.Read);
            byte[] buf2 = new byte[fs.Length - 44];
            fs.Position = 44;
            fs.Read(buf2, 0, buf2.Length);
            fs.Close();

            byte[] buf = new byte[(num1 + num2) * 2];

            for (int i = 0; i < e1 * 2; i++)
                buf[i] = buf1[i];

            for (int j = 0; j < (num2 - s2) * 2; j++)
                buf[j + e1] = buf2[j + s2];


            sampnum = e1 + num2 - s2;
            return buf;
        }*/
    }
}