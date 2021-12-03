using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text.RegularExpressions;

namespace EmojiDetector
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            BigInteger coolThresholdSum = new BigInteger();
            List<int> digits = new List<int>();

            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]))
                {
                    digits.Add(int.Parse(input[i].ToString()));
                }
            }

            coolThresholdSum = digits.Aggregate((x, y) => x * y);

            string pattern = @"(?<surrounder>:{2}|\*{2})[A-Z]{1}[a-z]{2,}\1";
            Regex emojiValidator = new Regex(pattern);

            var allMatches = emojiValidator.Matches(input);
            List<string> matches = new List<string>();

            foreach (var emoji in allMatches)
            {
                matches.Add(emoji.ToString());
            }

            int emojiCount = allMatches.Count;
            List<string> coolEmojis = new List<string>();

            for (int i = 0; i < matches.Count; i++)
            {
                BigInteger sum = 0;
                string curr = matches[i];
                for (int j = 0; j < curr.Length; j++)
                {
                    if (char.IsLetter(curr[j]))
                    {
                        char currentSymbol = curr[j];
                        sum += currentSymbol;
                    }
                }

                if (sum >= coolThresholdSum)
                {
                    coolEmojis.Add(matches[i]);
                }
            }
            Console.WriteLine($"Cool threshold: {coolThresholdSum}");
            Console.WriteLine($"{matches.Count} emojis found in the text. The cool ones are:");
            foreach (var emoji in coolEmojis)
            {
                Console.WriteLine(emoji);
            }
        }
    }
}
