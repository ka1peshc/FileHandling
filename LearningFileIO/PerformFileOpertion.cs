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
    }
}
