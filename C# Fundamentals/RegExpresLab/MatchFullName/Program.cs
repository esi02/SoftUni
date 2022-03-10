using System;
using System.Text.RegularExpressions;

namespace RegExpresLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";
            string names = Console.ReadLine();

            MatchCollection matchedNames = Regex.Matches(names, pattern);

            foreach (Match item in matchedNames)
            {
                Console.Write(item.Value + " ");
            }
            Console.WriteLine();
        }
    }
}
