using System.IO;

namespace Main
{
    public static class LogManager
    {
        /*
         * Write any incoming text to default_directory\objstore.log
         */
        public static void WriteLog(string text)
        {
            using (FileStream fs = new FileStream("objstore\\objstore.log", FileMode.Append, FileAccess.Write))
            using (StreamWriter sw = new StreamWriter(fs))
            {
                sw.WriteLine(text);
            }
        }
    }
}