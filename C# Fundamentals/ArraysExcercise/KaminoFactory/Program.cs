using System;
using System.Linq;

namespace KaminoFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            int onesCounter = 0;
            int mostOnesCounter = 0;

            int sum = 0;
            int greaterSum = 0;

            int bestIndex = 0;

            int[] dna;
            int[] bestSequence;
            while (command != "Clone them!")
            {
                dna = Console.ReadLine()
               .Split("!", StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .ToArray();

                bestSequence = new int[dna.Length];
                for (int i = 0; i < dna.Length; i++)
                {
                    if (dna[i] == 1)
                    {
                        onesCounter++;
                        sum += dna[i];
                    }
                    if (onesCounter > mostOnesCounter)
                    {
                        bestIndex = i;
                        mostOnesCounter = onesCounter;
                        bestSequence = dna;
                    }
                    if (dna[i] > bestIndex)
                    {
                        bestIndex = dna[i];
                    }
                    if (sum > greaterSum)
                    {
                        greaterSum = sum;
                    }
                }
            }
            Console.WriteLine($"Best DNA sample {bestIndex} with sum: {greaterSum}.");
            Console.WriteLine($"{string.Join(" ", bestSequence)}");
        }
    }
}
