using System;
using System.Collections.Generic;
using System.Linq;

namespace Messaging
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            List<string> stringg = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            List<int> sumOfCurrentElement = new List<int>();
            List<int> sumOfCurrentStringElement = new List<int>();

            for (int i = 0; i < stringg.Count; i++)
            {
                sumOfCurrentStringElement.Add(stringg[i].Length);
            }


            for (int i = 0; i < numbers.Count; i++)
            {
                int sumOfCurrentElementt = 0;
                int temp = numbers[i];
                for (int j = 0; numbers[i] > 0; j++)
                {
                    int currentNum = numbers[i] % 10;
                    sumOfCurrentElementt += currentNum;
                    numbers[i] = numbers[i] / 10;
                }
                sumOfCurrentElement.Add(sumOfCurrentElementt);
                numbers[i] = temp;

                
            }

            

        }
    }
}
