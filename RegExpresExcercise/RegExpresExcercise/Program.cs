using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace RegExpresExcercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @">>(?<name>[A-Za-z\s]+)<<(?<price>\d+(.\d+)?)!(?<quantity>\d+)";

            string furniture = Console.ReadLine();
            Dictionary<string, decimal> toPrint = new Dictionary<string, decimal>();
            MatchCollection matched;

            while (furniture != "Purchase")
            {
                matched = Regex.Matches(furniture, pattern);
                foreach (Match item in matched)
                {
                    decimal price = decimal.Parse(item.Groups["price"].Value);
                    decimal quantity = decimal.Parse(item.Groups["quantity"].Value);
                    decimal total = price * quantity;
                    toPrint.Add(item.Groups["name"].Value, total);
                }
                furniture = Console.ReadLine();
            }

            Console.WriteLine("Bought furniture:");
            if (toPrint.Count > 0)
            {
                foreach (var item in toPrint)
                {
                    Console.WriteLine(item.Key);
                }
            }
            decimal totalMoney = toPrint.Values.Sum();
            Console.WriteLine($"Total money spend: {totalMoney:f2}");
        }
    }
}
