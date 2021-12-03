using System;
using System.Collections.Generic;

namespace LettersChangeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> uppercaseAlphabet = new List<string>() { "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            List<string> lowercaseAlphabet = new List<string>();

            for (int i = 0; i < uppercaseAlphabet.Count; i++)
            {
                lowercaseAlphabet.Add(uppercaseAlphabet[i].ToLower());
            }

            string[] sequence = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            decimal totalSum = 0;

            foreach (var word in sequence)
            {
                char firstLetter = word[0];
                string number = string.Empty;
                char secondLetter = '\0';
                for (int i = 1; i < word.Length; i++)
                {
                    if (char.IsDigit(word[i]))
                    {
                        number += word[i];
                    }
                    else
                    {
                        secondLetter = word[i];
                    }
                }
                int num = int.Parse(number);
                int position = 0;
                if (char.IsUpper(firstLetter))
                {
                    for (int i = 0; i < uppercaseAlphabet.Count; i++)
                    {
                        if (firstLetter.ToString() == uppercaseAlphabet[i])
                        {
                            position = i + 1;
                            totalSum += (decimal)num /(decimal)position;
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < lowercaseAlphabet.Count; i++)
                    {
                        if (firstLetter.ToString() == lowercaseAlphabet[i])
                        {
                            position = i + 1;
                            totalSum += (decimal)num *(decimal)position;
                            break;
                        }
                    }
                }
                if (char.IsUpper(secondLetter))
                {
                    for (int i = 0; i < uppercaseAlphabet.Count; i++)
                    {
                        if (secondLetter.ToString() == uppercaseAlphabet[i])
                        {
                            position = i + 1;
                            totalSum -= position;
                            break;
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < lowercaseAlphabet.Count; i++)
                    {
                        if (secondLetter.ToString() == lowercaseAlphabet[i])
                        {
                            position = i + 1;
                            totalSum += position;
                            break;
                        }
                    }
                }
            }
            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
