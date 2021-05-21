using System;
using System.IO;

namespace TeamProject3
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


        public static void AddRecordToFile(string country, string year)
        {
            string text = country + "\t\t\t" + year + "\n";

            if (!File.Exists(filePath))
            {
                text = country + "\t\t\t" + year;
                string heading = "Country  \t\t Year \n";
                string[] headingAndText = {heading, text};
                File.AppendAllLines(filePath, headingAndText);
            }
            else
            {
                File.AppendAllText(filePath,text);
            }
        }
        public static void PrintFile()
        {
            Console.WriteLine(File.ReadAllText(filePath));
        }
    }
}