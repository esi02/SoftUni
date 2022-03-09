using System;
using System.Linq;

namespace RoundingNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] nums = Console.ReadLine()
                .Split()
                .Select(double.Parse)
                .ToArray();

            int[] rounded = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                //гърми заради нулата
                if (nums[i] == -0)
                {
                    nums[i] = 0;
                }
                rounded[i] = (int)Math.Round(nums[i], MidpointRounding.AwayFromZero);
                Console.WriteLine($"{nums[i]} => {rounded[i]}");
            }
        }
    }
}
