using System;
using System.Linq;

namespace EqualSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            bool flag = false;
            int middle = 0;
            if (array.Length == 1)
            {
                flag = true;
                middle = 0;
            }

            for (int i = 0; i < array.Length; i++)
            {
                int middleIndex = i + 1;
                int leftSum = 0;
                int rightSum = 0;

                for (int j = 0; j <= i; j++)
                {
                    leftSum += array[j];
                }

                for (int k = i + 2; k < array.Length; k++)
                {
                    rightSum += array[k];
                }

                if (leftSum == rightSum && array.Length > 1)
                {
                    flag = true;
                    middle = middleIndex;
                    break;
                }

            }
            if (!flag)
            {
                Console.WriteLine("no");
            }
            else
            {
                Console.WriteLine(middle);
            }
        }
    }
}
