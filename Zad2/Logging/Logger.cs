namespace Zad2.Logging
{
    class Logger
    {
        public static string LogFilePath { get; set; } = @"..\..\..\Logging\log.txt";

        public static void AddLog(string text)
        {
            using (StreamWriter w = File.AppendText(LogFilePath))
            {
                w.WriteLine(text);
                w.Close();
            }
        }
    }
}
