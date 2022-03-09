using System;
using System.Linq;

namespace _08._Custom_Comparator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            
            Console.WriteLine(string.Join(" ", Comparer(numbers)));
           
        }
        public static int[] Comparer(int[] nums)
        {
            var oddNums = nums.Where(x => x % 2 != 0).ToArray();
            var evenNums = nums.Where(x => x % 2 == 0).ToArray();
            var newArr = new int[evenNums.Length];

            for (int i = 0; i < evenNums.Length; i++)
            {
                newArr[i] = evenNums[i];
            }

            foreach (var item in oddNums)
            {
                newArr = newArr.Append(item).ToArray();
            }
            
            return newArr;
        }
    }
}
