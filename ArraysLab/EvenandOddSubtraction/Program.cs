﻿using System;
using System.Linq;

namespace EvenandOddSubtraction
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int evenSum = 0;
            int oddSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int currentNum = arr[i];
                if (currentNum % 2 == 0)
                {
                    evenSum += currentNum;
                }
                else
                {
                    oddSum += currentNum;
                }
            }

            Console.WriteLine(evenSum - oddSum);

        }
    }
}
