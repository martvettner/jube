using System;
using System.IO;

namespace WriteFilesAndDirectories
{
    class Program
    {
        static void Main(string[] args)
        {
            string filepath = @"C:\Users\opilanesamples\files.txt";
            string directorypath = @"C:\Users\opilane\samples";

            string[] files = Directory.GetFiles(directorypath, "*.*", SearchOption.AllDirectories);

            File.WriteAllLines(filepath, files);
            File.WriteAllLines(fileTxt, allFiles);


        }
        public static void
    }
}
