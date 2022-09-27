using System.IO;

namespace MailRemoverAPI.Util
{
    public class FileReadClass
    {
        //Properties
        private string fileName;
        public string FileName
        {
            get { return fileName; }
            set { fileName = value; }
        }

        private string filePath;
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        private string fileContents;
        public string FileContents
        {
            set { filePath = value; }
            get { return fileContents; }
        }

        public String readFile()
        {
            string text = System.IO.File.ReadAllText(FilePath);
            return text;
        }
    }   
}    