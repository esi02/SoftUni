using System;
using System.Collections.Generic;
using System.Linq;

namespace AdvancedExamPreparation
{
    class Program
    {
        static void Main(string[] args)
        {
            var ingredients = new Queue<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));
            var freshnessLevel = new Stack<int>(Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            SortedDictionary<string, int> dishesCount = new SortedDictionary<string, int>();
            dishesCount.Add("Dipping sauce", 0);
            dishesCount.Add("Green salad", 0);
            dishesCount.Add("Chocolate cake", 0);
            dishesCount.Add("Lobster", 0);

            while (ingredients.Count != 0 && freshnessLevel.Count != 0)
            {
                if (ingredients.Peek() == 0)
                {
                    ingredients.Dequeue();
                }

                int product = ingredients.Peek() * freshnessLevel.Peek();

                switch (product)
                {
                    case 150:
                        dishesCount["Dipping sauce"]++;
                        ingredients.Dequeue();
                        freshnessLevel.Pop();
                        break;
                    case 250:
                        dishesCount["Green salad"]++;
                        ingredients.Dequeue();
                        freshnessLevel.Pop();
                        break;
                    case 300:
                        dishesCount["Chocolate cake"]++;
                        ingredients.Dequeue();
                        freshnessLevel.Pop();
                        break;
                    case 400:
                        dishesCount["Lobster"]++;
                        ingredients.Dequeue();
                        freshnessLevel.Pop();
                        break;
                    default:
                        if (ingredients.Peek() == 0)
                        {
                            ingredients.Dequeue();
                        }
                        else
                        {
                            freshnessLevel.Pop();
                            int value = ingredients.Dequeue();
                            value += 5;
                            ingredients.Enqueue(value);
                        }
                        break;
                }
            }

            if (dishesCount.All(x => x.Value >= 1))
            {
                Console.WriteLine("Applause! The judges are fascinated by your dishes!");
            }
            else
            {
                Console.WriteLine("You were voted off. Better luck next year.");
                if (ingredients.Sum() > 0)
                {
                    Console.WriteLine($"Ingredients left: {ingredients.Sum()}");
                }
            }


            var toPrint = dishesCount.Where(x => x.Value >= 1);
            foreach (var dish in toPrint)
            {
                Console.WriteLine($" # {dish.Key} --> {dish.Value}");
            }
        }
    }
}
