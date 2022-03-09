using System;
using System.Collections.Generic;

namespace Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var numbers = new Dictionary<int, int>();

            for (int i = 1; i <= n; i++)
            {
                int num = int.Parse(Console.ReadLine());

                if (numbers.ContainsKey(num))
                {
                    numbers[num]++;
                }
                else
                {
                    numbers.Add(num, 1);
                }
            }

            int numToPrint = 0;
            foreach (var num in numbers)
            {
                if (num.Value % 2 == 0)
                {
                    numToPrint = num.Key;
                }
            }
            Console.WriteLine(numToPrint);
        }
    }
}
