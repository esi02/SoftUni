using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CharacterMultiplier
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arguments = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int sum = 0;

            string firstWord = arguments[0];
            string secondWord = arguments[1];

            if (firstWord.Length > secondWord.Length)
            {
                for (int i = 0; i < secondWord.Length; i++)
                {
                    for (int j = 0; j < firstWord.Length; j++)
                    {
                        sum += firstWord[i] * secondWord[i];
                        break;
                    }
                }
            }
            else if(secondWord.Length > firstWord.Length)
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    for (int j = 0; j < secondWord.Length; j++)
                    {
                        sum += firstWord[i] * secondWord[i];
                        break;
                    }
                }
            }
            else
            {
                for (int i = 0; i < firstWord.Length; i++)
                {
                    for (int j = 0; j < secondWord.Length; j++)
                    {
                        sum += firstWord[i] * secondWord[i];
                        break;
                    }
                }
            }

            List<char> remaining = new List<char>();

            if (firstWord.Length > secondWord.Length)
            {
                int rem = firstWord.Length - secondWord.Length;
                remaining = firstWord.TakeLast(rem).ToList();
            }
            else if (secondWord.Length > firstWord.Length)
            {
                int rem = secondWord.Length - firstWord.Length;
                remaining = secondWord.TakeLast(rem).ToList();
            }

            if (remaining.Count != 0)
            {
                for (int i = 0; i < remaining.Count; i++)
                {
                    sum += remaining[i];
                }
            }

            Console.WriteLine(sum);

        }
    }
}
