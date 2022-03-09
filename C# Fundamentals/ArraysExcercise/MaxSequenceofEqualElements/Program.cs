using System;
using System.Linq;

namespace MaxSequenceofEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int longest = 0;
            int foundCounter = 0;
            string sequence = string.Empty;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] == array[i + 1])
                {
                    foundCounter++;
                    if (foundCounter > longest)
                    {
                        longest = foundCounter;
                        sequence = array[i].ToString();
                    }
                }
                else
                {
                    foundCounter = 0;
                }
            }

            for (int i = 0; i <= longest; i++)
            {
                Console.Write(sequence + " ");
            }
        }
    }
}
