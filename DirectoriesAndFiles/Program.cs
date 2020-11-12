﻿using System;
using System.IO;

namespace DirectoriesAndFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            string rootPath = @"C:\Users\opilane\samples";

            string[] AllDirectories = Directory.GetDirectories(rootPath);
            //ReadArray(AllDirectories);

            string[] includeNestedDirectories = Directory.GetDirectories(rootPath, "*", SearchOption.AllDirectories);
            // ReadArray(includeNestedDirectories);

            string[] files = Directory.GetFiles(rootPath, "*.*", SearchOption.AllDirectories);
            ReadArray(files);


        }
        public static void ReadArray(string[] array)
        {
            foreach(string line in array)
            {
                Console.WriteLine(line);
            }

        }

    }
}
