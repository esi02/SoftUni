using System;
using System.Text;
using System.Linq;

namespace ReplaceRepeatingChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();

            int count = 0;
            bool isRepeating = false;

            for (int i = 0; i < text.Length; i++)
            {
                char currentLetter = text[i];
                count = 0;
                isRepeating = false;

                for (int j = i; j < text.Length - 1; j++)
                {
                    if (currentLetter == text[j + 1])
                    {
                        isRepeating = true;
                        count++;
                    }
                    if (currentLetter != text[j + 1])
                    {
                        break;
                    }
                }
                if (isRepeating)
                {
                    text = text.Remove(i + 1, count);
                }
            }
            Console.WriteLine(text);
        }
    }
}
