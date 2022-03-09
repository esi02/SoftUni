using System;

namespace SumOfTwoNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());
            //най-елементарната грешка - НАЧАЛНОТО ЧИСЛО В ЦИКЪЛА ТРЯБВА ДА Е СТАРТ ЗАЩОТО МЕЖДУ ДВЕТЕ ЧИСЛА
            int combinationCount = 0;
            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    combinationCount++;
                    if (i + j == magicNum)
                    {
                        Console.WriteLine($"Combination N:{combinationCount} ({i} + {j} = {magicNum})");
                        return;
                    }
                }
            }
            Console.WriteLine($"{combinationCount} combinations - neither equals {magicNum}");
        }
    }
}
