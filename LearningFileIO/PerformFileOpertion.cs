using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace LearningFileIO
{
    class PerformFileOpertion
    {
        public const string FILEPATH = @"D:\Bridgelabz lecture\Dot net\Day 27 C# File handling\TestingTextFile.txt";

        public static void FileExist()
        {
            if (File.Exists(FILEPATH))
                Console.WriteLine("It exists");
            else
                Console.WriteLine("Not present");
        }
    }
}
