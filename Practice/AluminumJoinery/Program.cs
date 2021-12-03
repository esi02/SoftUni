using System;

namespace AluminumJoinery
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            string model = Console.ReadLine();
            string delivery = Console.ReadLine();

            double price = 0;
            if (count < 10)
            {
                Console.WriteLine("Invalid order");
                return;
            }
            switch (model)
            {
                case "90X130":
                    price += 110;
                    price = price * count;
                    if (count >= 30 && count < 60)
                    {
                        price *= 0.95;
                    }
                    else if (count >= 60)
                    {
                        price *= 0.92;
                    }
                    break;
                case "100X150":
                    price += 140;
                    price = price * count;
                    if (count >= 40 && count < 80)
                    {
                        price *= 0.94;
                    }
                    else if (count >= 80)
                    {
                        price *= 0.90;
                    }
                    break;
                case "130X180":
                    price += 190;
                    price = price * count;
                    if (count >= 20 && count < 50)
                    {
                        price *= 0.93;
                    }
                    else if (count >= 50)
                    {
                        price *= 0.88;
                    }
                    break;
                case "200X300":
                    price += 250;
                    price = price * count;
                    if (count >= 25 && count < 50)
                    {
                        price *= 0.91;
                    }
                    else if (count >= 50)
                    {
                        price *= 0.86;
                    }
                    break;
            }
            if (delivery == "With delivery")
            {
                price += 60;
            }
            if (count > 99)
            {
                price *= 0.96;
            }
            Console.WriteLine($"{price:f2} BGN");
        }
    }
}
