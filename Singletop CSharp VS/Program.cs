using System;

namespace Singletop_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var text1 = new FileWorker();
            var text2 = new FileWorker();

            text1.WriteText("Hello, Biba!");
            text2.WriteText("Hello, Bro!");

            text1.Save();
            text2.Save();

            var singleton1 = FileWorkerSingleton.Instance;
            var singleton2 = FileWorkerSingleton.Instance;

            singleton1.WriteText("Hello, World!");
            singleton2.WriteText("Hello, Bro!");

            singleton1.Save();
            singleton2.Save();

        }
    }
}
