using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Singletop_CSharp
{ 
    public class FileWorker
    {
        public string FilePath { get; }

        public string Text { get; private set; }

        public FileWorker()
        {
            FilePath = "test.txt";
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
