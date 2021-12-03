using System;

namespace ComputerStore
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            decimal totalPriceWithTaxes = 0;
            decimal totalPriceWithoutTaxes = 0;
            decimal taxes = 0;
            decimal price = 0;

            while (command != "special" && command != "regular")
            {
                price = decimal.Parse(command);

                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    command = Console.ReadLine();
                    continue;
                }
                taxes += price * 0.20m;
                totalPriceWithoutTaxes += price;


                command = Console.ReadLine();
            }

            totalPriceWithTaxes = totalPriceWithoutTaxes + taxes;

            if (totalPriceWithTaxes == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            if (command == "special")
            {
                totalPriceWithTaxes *= 0.90m;
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPriceWithoutTaxes:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPriceWithTaxes:f2}$");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPriceWithoutTaxes:f2}$");
                Console.WriteLine($"Taxes: {taxes:f2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPriceWithTaxes:f2}$");
            }
        }
    }
}
