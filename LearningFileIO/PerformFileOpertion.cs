using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


namespace LearningFileIO
{
    class PerformFileOpertion
    {
        public const string FILEPATH = @"D:\Bridgelabz lecture\Dot net\Day 27 C# File handling\TestingTextFile.txt";
        /// <summary>
        /// Checks wheather file is available or not in given location
        /// </summary>
        public static void FileExist()
        {
            if (File.Exists(FILEPATH))
                Console.WriteLine("It exists");
            else
                Console.WriteLine("Not present");
        }
        /// <summary>
        /// Read file one line at a time and store it in array
        /// </summary>
        public static void ReadAllLines()
        {
            string[] lines;
            try
            {
                lines = File.ReadAllLines(FILEPATH);
                for(int i = 0; i < lines.Length; i++)
                {
                    Console.WriteLine(lines[i]);
                }
                return;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
        }

        /// <summary>
        /// Read whole file as a single string
        /// </summary>
        public static void ReadAllText()
        {
            string lines;
            try
            {
                lines = File.ReadAllText(FILEPATH);
                Console.WriteLine(lines);
                return;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
        }
        /// <summary>
        /// Copy file from source to other file
        /// </summary>
        public static void FileCopy()
        {
            try
            {
                string copypath = @"D:\Bridgelabz lecture\Dot net\Day 27 C# File handling\TestingTextFileCopy.txt";
                File.Copy(FILEPATH, copypath);
                return;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
        }
        /// <summary>
        /// Delete file given in file path
        /// </summary>
        public static void DeleteFile()
        {
            try
            {
                string copypath = @"D:\Bridgelabz lecture\Dot net\Day 27 C# File handling\TestingTextFileCopy.txt";
                File.Delete(copypath);
                return;
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
        }
        /// <summary>
        /// Read file using StreamReader namespace
        /// </summary>
        public static void ReadStringUsingStreamReader()
        {
            using StreamReader sr = File.OpenText(FILEPATH);
            string readText = "";
            while((readText= sr.ReadLine()) != null)
            {
                Console.WriteLine(readText);
            }
            sr.Close();
        }
    }
}
