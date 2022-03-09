using System;
using System.Text.RegularExpressions;

namespace AdAstra
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Regex pattern = new Regex(@"(\||#)(?<itemName>[A-Za-z\s]+)\1(?<expirationDate>\d{2}\/\d{2}\/\d{2})\1(?<calories>\d+)\1");

            MatchCollection foodItems = pattern.Matches(input);

            int totalCalories = 0;

            foreach (Match food in foodItems)
            {
                totalCalories += int.Parse(food.Groups["calories"].Value);
            }

            int days = totalCalories / 2000;
            Console.WriteLine($"You have food to last you for: {days} days!");

            foreach (Match food in foodItems)
            {
                Console.WriteLine($"Item: {food.Groups["itemName"].Value}, Best before: {food.Groups["expirationDate"].Value}, Nutrition: {food.Groups["calories"].Value}");
            }
        }
    }
}
