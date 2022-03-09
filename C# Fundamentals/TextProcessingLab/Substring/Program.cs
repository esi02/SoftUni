using System;

namespace Substring
{
    class Program
    {
        static void Main(string[] args)
        {
            string removeWord = Console.ReadLine();
            string word = Console.ReadLine();

            while (word.Contains(removeWord))
            {
                int index = word.IndexOf(removeWord);
                word = word.Remove(index, removeWord.Length);
            }
            Console.WriteLine(word);
        }
    }
}
