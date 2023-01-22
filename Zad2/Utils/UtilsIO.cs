namespace Zad2.Utils
{
    internal class UtilsIO
    {
        public static string GetFilePath(string file)
        {
            string sCurrentDirectory = AppDomain.CurrentDomain.BaseDirectory;
            string filePath = Path.Combine(sCurrentDirectory, file);
            string sFilePath = Path.GetFullPath(filePath);

            return sFilePath;
        }

        public static bool IsValidPath(string path, bool exactPath = true)
        {
            bool isValid = true;

            try
            {
                string fullPath = Path.GetFullPath(path);

                if (exactPath)
                {
                    string root = Path.GetPathRoot(path);
                    isValid = string.IsNullOrEmpty(root.Trim(new char[] { '\\', '/' })) == false;
                }
                else
                {
                    isValid = Path.IsPathRooted(path);
                }
            }
            catch (Exception)
            {
                isValid = false;
            }

            return isValid;
        }
    }
}
