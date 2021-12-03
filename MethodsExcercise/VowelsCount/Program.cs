using System;
using System.Linq;

namespace VowelsCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            PrintVowelsCount(input);
        }

        static int PrintVowelsCount(string input)
        {
            int vowelCount = input.Count(x => "aeiou".Contains(Char.ToLower(x)));
            Console.WriteLine(vowelCount);
                return vowelCount;
        }
    }
}
