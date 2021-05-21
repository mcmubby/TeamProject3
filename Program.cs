using System;
using System.IO;
using System.Threading.Tasks;

namespace TeamProject3
{
    class Program
    {
        static  void Main(string[] args)
        {
            Document.FileSystemCheck();


            Console.Write("Enter Country Name : ");
            var countryName = Console.ReadLine().ToUpper().Trim();

            Console.Write($"What year did {countryName} win the World Cup? : ");
            var year = Console.ReadLine().Trim();
            
            Document.AddRecordToFile(countryName, year);
            Document.PrintFile();
        }
    }
}
