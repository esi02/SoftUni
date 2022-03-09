using System;
using System.Collections.Generic;
using System.Linq;

namespace Cooking
{
    class Program
    {
        static void Main(string[] args)
        {
            var liquids = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));
            var ingredients = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse));

            var food = new SortedDictionary<string, int>();
            food.Add("Bread", 0);
            food.Add("Cake", 0);
            food.Add("Pastry", 0);
            food.Add("Fruit Pie", 0);

            while (liquids.Count > 0 && ingredients.Count > 0)
            {
                int mix = liquids.Peek() + ingredients.Peek();

                switch (mix)
                {
                    case 25:
                        food["Bread"]++;
                        liquids.Dequeue();
                        ingredients.Pop();
                        break;
                    case 50:
                        food["Cake"]++;
                        liquids.Dequeue();
                        ingredients.Pop();
                        break;
                    case 75:
                        food["Pastry"]++;
                        liquids.Dequeue();
                        ingredients.Pop();
                        break;
                    case 100:
                        food["Fruit Pie"]++;
                        liquids.Dequeue();
                        ingredients.Pop();
                        break;
                    default:
                        liquids.Dequeue();
                        int value = ingredients.Pop();
                        value += 3;
                        ingredients.Push(value);
                        break;
                }
            }

            if (food.All(x => x.Value >= 1))
            {
                Console.WriteLine("Wohoo! You succeeded in cooking all the food!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to cook everything.");
            }

            if (liquids.Count > 0)
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (ingredients.Count > 0)
            {
                Console.WriteLine($"Ingredients left: {string.Join(", ", ingredients)}");
            }
            else
            {
                Console.WriteLine($"Ingredients left: none");
            }

            foreach (var item in food)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
        }
    }
}
