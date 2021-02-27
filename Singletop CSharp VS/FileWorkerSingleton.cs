using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Singletop_CSharp
{
    public sealed class FileWorkerSingleton
    {
        // here is stored one exemplar of class
        private static readonly Lazy<FileWorkerSingleton> instance =
            new Lazy<FileWorkerSingleton>(() => new FileWorkerSingleton());

        public static FileWorkerSingleton Instance { get { return instance.Value; } }

        // path to file
        public string FilePath { get; }

        // content of file in dynamic memory
        public string Text { get; private set; }

        private FileWorkerSingleton()
        {
            FilePath = "text2.txt";
            ReadTextFromFile();
        }

        public void WriteText(string text)
        {
            Text += text;
        }

        public void Save()
        {
            using (var writer = new StreamWriter(FilePath, false))
            {
                writer.WriteLine(Text);
            }
        }

        private void ReadTextFromFile()
        {
            if (!File.Exists(FilePath))
            {
                Text = "";
            }
            else
            {
                using (var reader = new StreamReader(FilePath))
                {
                    Text = reader.ReadToEnd();
                }
            }
        }
    }
}
