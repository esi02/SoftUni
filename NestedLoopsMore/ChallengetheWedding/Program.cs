using System;

namespace ChallengetheWedding
{
    class Program
    {
        static void Main(string[] args)
        {
            int menCount = int.Parse(Console.ReadLine());
            int womenCount = int.Parse(Console.ReadLine());
            int maxTablesCount = int.Parse(Console.ReadLine());

            int counter = 0;
            //един цикъл ми е бил напълно излишен
            for (int j = 1; j <= menCount; j++)
            {
                for (int k = 1; k <= womenCount; k++)
                {
                    Console.Write($"({j} <-> {k}) ");
                    counter++;
                    if (counter == maxTablesCount)
                    {
                        return;
                    }
                }
            }
        }
    }
}
