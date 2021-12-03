using System;
using System.Collections.Generic;
using System.Linq;

namespace ObjectsAndClassesLab
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = Console.ReadLine()
                 .Split()
                 .ToArray();

            Random rnd = new Random();

            for (int i = 0; i < words.Length; i++)
            {
                int swapPosition = rnd.Next(words.Length);
                string temp = words[i];
                words[i] = words[swapPosition];
                words[swapPosition] = temp;
            }
            Console.WriteLine(string.Join(Environment.NewLine, words));
        }
    }
}
