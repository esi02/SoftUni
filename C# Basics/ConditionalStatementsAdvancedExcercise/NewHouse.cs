using System;

namespace NewHouse
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            int count = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double discount = 1;
            double price = 0;
            switch (type)
            {
                case "Roses":
                        price = 5;
                    if (count > 80)
                    {
                        discount = 0.90;
                    }
                    break;
                case "Dahlias":
                        price = 3.80;
                    if (count > 90)
                    {
                        discount = 0.85;
                    }
                    break;
                case "Tulips":
                        price = 2.80;
                    if (count > 80)
                    {
                        discount = 0.85;
                    }
                    break;
                case "Narcissus":
                        price = 3;
                    if (count < 120)
                    {
                        discount = 1.15;
                    }
                    break;
                default:
                        price = 2.50;
                    if (count < 80)
                    {
                        discount = 1.20;
                    }
                    break;
            }
            double finalPrice = (price * count)  * discount;
            if (budget >= finalPrice)
            {
                Console.WriteLine($"Hey, you have a great garden with {count} {type} and {budget - finalPrice:f2} leva left.");
            }
            else
            {

            Console.WriteLine($"Not enough money, you need {finalPrice - budget:f2} leva more.");
            }
                    
           
        }
    }
}
