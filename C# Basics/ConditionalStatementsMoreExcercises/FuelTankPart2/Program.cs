using System;

namespace FuelTankPart2
{
    class Program
    {
        static void Main(string[] args)
        {
            string fuelType = Console.ReadLine();
            double fuelLiters = double.Parse(Console.ReadLine());
            string clubCard = Console.ReadLine();

            double benzinPricePerLiter = 2.22;
            double dieselPricePerLiter = 2.33;
            double gasPricePerLiter = 0.93;

            if (fuelType == "Gas")
            {
                double totalPrice = fuelLiters * gasPricePerLiter;
                if (fuelLiters >= 20 && fuelLiters <= 25)
                {
                    if (clubCard == "Yes")
                    {
                        double gasPriceAfterDiscount = (gasPricePerLiter - 0.08) * fuelLiters;
                        Console.WriteLine($"{(gasPriceAfterDiscount * 0.92):f2} lv.");
                    }
                    else
                    {
                    double gasPrice = totalPrice * 0.92; 
                        Console.WriteLine($"{gasPrice:f2} lv.");
                    }
                }
                else if (fuelLiters > 25)
                {
                    if (clubCard == "Yes")
                    {
                        double gasPriceAfterDiscount = (gasPricePerLiter - 0.08) * fuelLiters;
                        Console.WriteLine($"{(gasPriceAfterDiscount * 0.90):f2} lv.");
                    }
                    else
                    {
                    double gasPrice = totalPrice * 0.90;
                        Console.WriteLine($"{gasPrice:f2} lv.");
                    }
                }
                else
                {
                    Console.WriteLine($"{totalPrice:f2} lv.");
                }
            }
            else if (fuelType == "Gasoline")
            {
                double totalPrice = fuelLiters * benzinPricePerLiter;
                if (fuelLiters >= 20 && fuelLiters <= 25)
                {
                    if (clubCard == "Yes")
                    {
                        double benzinPriceAfterDiscount = (benzinPricePerLiter - 0.18) * fuelLiters;
                        Console.WriteLine($"{(benzinPriceAfterDiscount * 0.92):f2} lv.");
                    }
                    else
                    {
                        double benzinPrice = totalPrice * 0.92;
                        Console.WriteLine($"{benzinPrice:f2} lv.");
                    }
                }
                else if (fuelLiters > 25)
                {
                    if (clubCard == "Yes")
                    {
                        double benzinPriceAfterDiscount = (benzinPricePerLiter - 0.18) * fuelLiters;
                        Console.WriteLine($"{(benzinPriceAfterDiscount * 0.90):f2} lv.");
                    }
                    else
                    {
                        double benzinPrice2 = totalPrice * 0.90;
                        Console.WriteLine($"{benzinPrice2:f2} lv.");
                    }
                }
                else
                {
                    Console.WriteLine($"{totalPrice:f2} lv.");
                }
            }
            else if (fuelType == "Diesel")
            {
                double totalPrice = fuelLiters * dieselPricePerLiter;
                if (fuelLiters >= 20 && fuelLiters <= 25)
                {
                    if (clubCard == "Yes")
                    {
                        double dieselPriceAfterDiscount = (dieselPricePerLiter - 0.12) * fuelLiters;
                        Console.WriteLine($"{(dieselPriceAfterDiscount * 0.92):f2} lv.");
                    }
                    else
                    {
                        double dieselPrice = totalPrice * 0.92;
                        Console.WriteLine($"{dieselPrice:f2} lv.");
                    }
                }
                else if (fuelLiters > 25)
                {
                    if (clubCard == "Yes")
                    {
                        double dieselPriceAfterDiscount = (dieselPricePerLiter - 0.12) * fuelLiters;
                        Console.WriteLine($"{(dieselPriceAfterDiscount * 0.90):f2} lv.");
                    }
                    else
                    {
                        double dieselPrice = totalPrice * 0.90;
                        Console.WriteLine($"{dieselPrice:f2} lv.");
                    }
                }
                else
                {
                    Console.WriteLine($"{totalPrice:f2} lv.");
                }
            }
        }
    }
}
