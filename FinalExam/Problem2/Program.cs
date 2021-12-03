using System;
using System.Text.RegularExpressions;

namespace Problem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex pattern = new Regex(@"(\*|@)(?<tag>[A-Z][a-z]{2,})\1:\s{1}\[(?<group1>[A-Za-z0-9])\]\|\[(?<group2>[A-Za-z0-9])\]\|\[(?<group3>[A-Za-z0-9])\]\|$");

            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                string input = Console.ReadLine();

                if (pattern.IsMatch(input))
                {
                    MatchCollection all = pattern.Matches(input);
                    string tag = string.Empty;
                    char firstGroup = '\0';
                    char secondGroup = '\0';
                    char thirdGroup = '\0';
                    foreach (Match item in all)
                    {
                        tag = item.Groups["tag"].Value;
                        firstGroup = char.Parse(item.Groups["group1"].Value);
                        secondGroup = char.Parse(item.Groups["group2"].Value);
                        thirdGroup = char.Parse(item.Groups["group3"].Value);
                    }
                    Console.WriteLine($"{tag}: {(int)firstGroup} {(int)secondGroup} {(int)thirdGroup}");
                }
                else
                {
                    Console.WriteLine("Valid message not found!");
                }
            }
        }
    }
}
