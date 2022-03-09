using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RegularExam_Advanced
{
    class Program
    {
        static void Main(string[] args)
        {
            var vowels = new Queue<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));
            var consonants = new Stack<string>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries));

            string pear = "pear";
            string flour = "flour";
            string pork = "pork";
            string olive = "olive";

            int pearCharsCount = 0;
            int flourCharsCount = 0;
            int porkCharsCount = 0;
            int oliveCharsCount = 0;

            List<string> foundWords = new List<string>();

            string sb = string.Empty;
            while (consonants.Count > 0)
            {
                string vowel = vowels.Peek();
                string cons = consonants.Peek();

                if (pear.Contains(vowel) && !sb.Contains(vowel))
                {
                    if (pearCharsCount < pear.Length)
                    {
                        pearCharsCount++;
                    }
                }
                if (pear.Contains(cons) && !sb.Contains(cons))
                {
                    if (pearCharsCount < pear.Length)
                    {
                        pearCharsCount++;
                    }
                }

                if (flour.Contains(vowel) && !sb.Contains(vowel))
                {
                    if (flourCharsCount < flour.Length)
                    {
                        flourCharsCount++;
                    }
                }
                if (flour.Contains(cons) && !sb.Contains(cons))
                {
                    if (flourCharsCount < flour.Length)
                    {
                        flourCharsCount++;
                    }
                }

                if (pork.Contains(vowel) && !sb.Contains(vowel))
                {
                    if (porkCharsCount < pork.Length)
                    {
                        porkCharsCount++;
                    }
                }
                if (pork.Contains(cons) && !sb.Contains(cons))
                {
                    if (porkCharsCount < pork.Length)
                    {
                        porkCharsCount++;
                    }
                }

                if (olive.Contains(vowel) && !sb.Contains(vowel))
                {
                    if (oliveCharsCount < olive.Length)
                    {
                        oliveCharsCount++;
                    }
                }
                if (olive.Contains(cons) && !sb.Contains(cons))
                {
                    if (oliveCharsCount < olive.Length)
                    {
                        oliveCharsCount++;
                    }
                }

                if (!sb.Contains(vowel))
                {
                    sb += vowel;
                }
                if (!sb.Contains(cons))
                {
                    sb += cons;
                }
                vowels.Dequeue();
                vowels.Enqueue(vowel);
                consonants.Pop();

            }

            if (pear.Length == pearCharsCount)
            {
                foundWords.Add("pear");
            }
            if (flour.Length == flourCharsCount)
            {
                foundWords.Add("flour");
            }
            if (pork.Length == porkCharsCount)
            {
                foundWords.Add("pork");
            }
            if (olive.Length == oliveCharsCount)
            {
                foundWords.Add("olive");
            }

            Console.WriteLine($"Words found: {foundWords.Count}");
            foreach (var item in foundWords)
            {
                Console.WriteLine(item);
            }
        }
    }
}
