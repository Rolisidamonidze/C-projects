using System;
using System.IO;
using System.Text;

namespace streams
{
    class Program
    {
        static void Main()
        {
            string text = "სატესტო ტექსტი. Testing Text.";
            string path = @"D:\test.txt";

            using FileStream stream = new FileStream(path, FileMode.Create);
            StreamWriter streamWriter = new StreamWriter(stream);
            {
                streamWriter.Write(text);
            }
        }
    }
}
