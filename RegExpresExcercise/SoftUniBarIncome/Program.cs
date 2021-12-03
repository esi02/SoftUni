using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace SoftUniBarIncome
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            string customerPattern = @"%[A-Z][a-z]+%";
            string productPattern = @"<\w+>";
            string countPattern = @"\|\d+\|";
            string pricePattern = @"\d+\.*\d*\$";

            decimal totalForAll = 0;

            while (input != "end of shift")
            {
                var coll = Regex.Matches(input, customerPattern).ToArray();
                string customer = string.Empty;
                if (coll.Length > 0)
                {
                    customer += coll[0];
                    customer = customer.Replace("%", string.Empty);
                }

                var coll2 = Regex.Matches(input, productPattern).ToArray();
                string product = string.Empty;
                if (coll2.Length > 0)
                {
                    product += coll2[0];
                    product = product.Replace("<", string.Empty);
                    product = product.Replace(">", string.Empty);
                }

                var coll3 = Regex.Matches(input, countPattern).ToArray();
                decimal count = 0;
                if (coll3.Length > 0)
                {
                    string temp = coll3[0].ToString();
                    temp = temp.Replace("|", string.Empty);
                    count = decimal.Parse(temp);
                }

                var coll4 = Regex.Matches(input, pricePattern).ToArray();
                decimal price = 0;
                if (coll4.Length > 0)
                {
                    string temp1 = coll4[0].ToString();
                    temp1 = temp1.Replace("$", string.Empty);
                    price += decimal.Parse(temp1);
                }

                if (customer != string.Empty && count > 0 && price > 0 && product != string.Empty)
                {
                    decimal total = price * count;
                    totalForAll += total;
                    Console.WriteLine($"{customer}: {product} - {total:f2}");
                }

                input = Console.ReadLine();
            }
            Console.WriteLine($"Total income: {totalForAll:f2}");
        }
    }
}
