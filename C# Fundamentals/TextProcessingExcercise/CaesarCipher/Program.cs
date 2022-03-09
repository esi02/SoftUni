using System;
using System.Text;

namespace CaesarCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] text = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            StringBuilder encryptedText = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                string currentWord = text[i];
                for (int j = 0; j < currentWord.Length; j++)
                {
                    int position = currentWord[j] + 3;
                    char character = (char)position;
                    encryptedText.Append(character);
                }
                if (i != text.Length - 1)
                {
                    encryptedText.Append("#");
                }
            }
            Console.WriteLine(encryptedText);
        }
    }
}
