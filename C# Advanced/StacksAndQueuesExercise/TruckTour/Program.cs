using System;
using System.Collections.Generic;
using System.Linq;

namespace TruckTour
{
    class Program
    {
        static void Main(string[] args)
        {
            int petrolPumps = int.Parse(Console.ReadLine());
            Queue<int> pumps = new Queue<int>();

            

            for (int i = 0; i <= petrolPumps - 1; i++)
            {
                int[] amountAndDistance = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();
                int amount = amountAndDistance[0];
                int distance = amountAndDistance[1];

                pumps.Enqueue(amount);
            }

        }
    }
}
