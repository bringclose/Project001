
//ReadFromFile
namespace Speaker
{
    class ReadFromFile
    {
        static string dataFile = @".\..\..\res\data.dat";
        public static void ReadingText()
        {
            string text = System.IO.File.ReadAllText(dataFile);
            System.Console.WriteLine("Contents of WriteText.txt = {0}", text);
        }
    }
}