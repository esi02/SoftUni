using System;
using System.Collections.Generic;
using System.Linq;

namespace TextProcessingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            string rev = string.Empty;
            Dictionary<string, string> words = new Dictionary<string, string>();

            while (command != "end")
            {
                char[] reversedWord = command.ToCharArray();
                Array.Reverse(reversedWord);
                rev = new string(reversedWord);
                words.Add(command, rev);

                command = Console.ReadLine();
            }

            foreach (var item in words)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }
        }
    }
}
