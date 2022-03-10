using System;

namespace FirstProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            int biscuitsPerWorkerADay = int.Parse(Console.ReadLine());
            int countOfWorkers = int.Parse(Console.ReadLine());
            int competingFactoryBiscuitsPerMonth = int.Parse(Console.ReadLine());


            double biscuitsPerMonth = 0;

            for (int i = 1; i <= 30; i++)
            {
                int biscuitsPerDay = biscuitsPerWorkerADay * countOfWorkers;
                if (i % 3 == 0)
                {
                    biscuitsPerDay = (int)(biscuitsPerDay * 0.75);
                }

                biscuitsPerMonth += biscuitsPerDay;

            }

            Console.WriteLine($"You have produced {biscuitsPerMonth} biscuits for the past month.");

            double difference = Math.Abs(competingFactoryBiscuitsPerMonth - biscuitsPerMonth);
            double percentage = (difference / competingFactoryBiscuitsPerMonth) * 100;

            if (competingFactoryBiscuitsPerMonth > biscuitsPerMonth)
            {
                Console.WriteLine($"You produce {percentage:f2} percent less biscuits.");
            }
            else
            {
                Console.WriteLine($"You produce {percentage:f2} percent more biscuits.");
            }
        }
    }
}
