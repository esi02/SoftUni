using System;
using System.Linq;

namespace Problem3
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] priceRatings = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int entryPoint = int.Parse(Console.ReadLine());
            string typeOfItems = Console.ReadLine();

          

            var leftArray = priceRatings.Take(entryPoint).ToArray();
            var rightArray = priceRatings.Skip(entryPoint + 1).ToArray();



            int leftDamage = 0;
            int rightDamage = 0;

            for (int i = 0; i < leftArray.Length; i++)
            {
                if (typeOfItems == "cheap")
                {
                    if (leftArray[i] < priceRatings.ElementAt(entryPoint))
                    {
                        leftDamage += leftArray[i];
                    }
                }
                else if (typeOfItems == "expensive")
                {
                    if (leftArray[i] >= priceRatings.ElementAt(entryPoint))
                    {
                        leftDamage += leftArray[i];
                    }
                }
            }
            for (int i = 0; i < rightArray.Length; i++)
            {
                if (typeOfItems == "cheap")
                {
                    if (rightArray[i] < priceRatings.ElementAt(entryPoint))
                    {
                        rightDamage += rightArray[i];
                    }
                }
                else if (typeOfItems == "expensive")
                {
                    if (rightArray[i] >= priceRatings.ElementAt(entryPoint))
                    {
                        rightDamage += rightArray[i];
                    }
                }
            }

            if (rightDamage == leftDamage)
            {
                Console.WriteLine($"Left - {leftDamage}");
            }
            else
            {
                if (rightDamage > leftDamage)
                {
                    Console.WriteLine($"Right - {rightDamage}");
                }
                else
                {
                    Console.WriteLine($"Left - {leftDamage}");
                }
            }
        }
    }
}
