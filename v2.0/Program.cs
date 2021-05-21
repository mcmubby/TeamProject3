using System;

namespace v2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Document.FileSystemCheck();
            Document.WriteRecordToFile();
            Document.PrintFile();
        }
    }
}
