using System.IO;

namespace AssistantLostArk
{
    internal class CreateRef
    {
        private static string pathThisDirectory = Directory.GetCurrentDirectory();
        private static string pathThisResources = Directory.GetCurrentDirectory()+"\\"+"Data";

        public static void CreateDirectory(string nameDirectory)
        {
            if(!Directory.Exists(pathThisDirectory + "\\" + nameDirectory))
            {
                Directory.CreateDirectory(pathThisDirectory+"\\" + nameDirectory);
            }
        }
        public static string CreateFile(string fileName)
        {
            string pathFile = pathThisResources + "\\" + fileName;
            if (Directory.Exists(pathThisResources) && !File.Exists(pathFile))
            {
                File.Create(pathFile).Close();
            }
            else if (!Directory.Exists(pathThisResources))
            {
                CreateDirectory("Data");
                CreateFile(fileName);
            }
            return pathFile;
        }
    }
}
