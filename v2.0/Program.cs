using System;

namespace v2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Document.FileSystemCheck();
                Document.WriteRecordToFile();
                Document.PrintFile();
            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
            }
        }
    }
}
