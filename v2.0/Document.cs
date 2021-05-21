using System;
using System.IO;

namespace v2._0
{
    public class Document
    {
        private static string folderPath = "FIFA";
        private static string filePath = @"FIFA\WorldCupWinners.txt";

        public static void FileSystemCheck()
        {
            CreateFolder();
        }

        private static void CreateFolder()
        {
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
        }


        public static void WriteRecordToFile()
        {
            if (!File.Exists(filePath))
            {
                string heading = "Year  \t\t Country \n\n";
                File.AppendAllText(filePath,heading);
                var content = Record.LoadWorldCupRecord();
                File.AppendAllLines(filePath, content);       
            }
            else
            {
                Console.WriteLine("WorldCupWinners.txt already exist. Kindly check FIFA folder.\n");
            }
        }

        public static void PrintFile()
        {
            Console.WriteLine(File.ReadAllText(filePath));
        }
    }
}