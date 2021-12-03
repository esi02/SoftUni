using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace MirrorWords
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            Regex pattern = new Regex(@"(@|#)[A-Za-z]{3,}\1{2}[A-Za-z]{3,}\1");

            List<string> pairs = new List<string>();

            var wordPairs = pattern.Matches(text);

            foreach (var item in wordPairs)
            {
                pairs.Add(item.ToString());
            }

            Dictionary<string, string> matchedWords = new Dictionary<string, string>();

            for (int i = 0; i < pairs.Count; i++)
            {
                char[] separators = new char[] { '@', '#' };
                string[] pairsArgs = pairs[i].Split(separators, StringSplitOptions.RemoveEmptyEntries);

                string firstWord = pairsArgs[0];
                string secondWord = pairsArgs[1];

                string reversedFirst = string.Empty;
                string reversedSecond = string.Empty;

                var temp = firstWord.Reverse()
                    .Select(x => reversedFirst += x)
                    .ToArray();
                var temp1 = secondWord.Reverse()
                    .Select(x => reversedSecond += x)
                    .ToArray();

                if (reversedFirst == secondWord && reversedSecond == firstWord)
                {
                    matchedWords.Add(firstWord, secondWord);
                }
            }
            if (wordPairs.Count > 0)
            {
                Console.WriteLine($"{wordPairs.Count} word pairs found!");
            }
            else
            {
                Console.WriteLine("No word pairs found!");
            }

            if (matchedWords.Count > 0)
            {
                Console.WriteLine("The mirror words are:");
                int count = 0;
                foreach (var word in matchedWords)
                {
                    count++;
                    if (count == matchedWords.Count)
                    {
                        Console.Write($"{word.Key} <=> {word.Value}");
                    }
                    else
                    {
                        Console.Write($"{word.Key} <=> {word.Value}, ");
                    }
                }
            }
            else
            {
                Console.WriteLine("No mirror words!");
            }
        }
    }
}
