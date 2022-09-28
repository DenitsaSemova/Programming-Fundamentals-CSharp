using System;
using System.IO;

namespace P05FolderSize
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("TestFolder");

            double sum = 0;

            foreach (string file in files)
            {
                FileInfo fileinfo = new FileInfo(file);
                sum += fileinfo.Length;
            }

            sum = sum / 1024 / 1024;

            File.WriteAllText("output.txt", sum.ToString());
        }
    }
}
