using System;
using System.Linq;
using System.Text;

namespace ExtractFile
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] separators = new char[] { '.', '\u005C' };
            string[] file = Console.ReadLine().Split(separators, StringSplitOptions.RemoveEmptyEntries);

            string fileName = file[file.Length - 2];
            string extension = file[file.Length - 1];

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {extension}");
        }
    }
}
