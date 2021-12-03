using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();

            double totalMoney = 0;
            while (command != "Start")
            {
                double money = double.Parse(command);

                if (money == 0.1)
                {
                    totalMoney += 0.1;
                }
                else if (money == 0.2)
                {
                    totalMoney += 0.2;
                }
                else if (money == 0.5)
                {
                    totalMoney += 0.5;
                }
                else if (money == 1)
                {
                    totalMoney += 1;
                }
                else if (money == 2)
                {
                    totalMoney += 2;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {money}");
                    command = Console.ReadLine();
                    continue;
                }
                command = Console.ReadLine();
            }

            command = Console.ReadLine();
            while (command != "End")
            {
                if (totalMoney <= 0)
                {
                    Console.WriteLine("Sorry, not enough money");
                    break;
                }
                switch (command)
                {
                    case "Nuts":
                        if (totalMoney < 2)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            break;
                        }
                        totalMoney -= 2;
                        Console.WriteLine($"Purchased {command.ToLower()}");
                        break;
                    case "Water":
                        if (totalMoney < 0.7)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            break;
                        }
                        totalMoney -= 0.7;
                        Console.WriteLine($"Purchased {command.ToLower()}");
                        break;
                    case "Crisps":
                        if (totalMoney < 1.5)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            break;
                        }
                        totalMoney -= 1.5;
                        Console.WriteLine($"Purchased {command.ToLower()}");
                        break;
                    case "Soda":
                        if (totalMoney < 0.8)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            break;
                        }
                        totalMoney -= 0.8;
                        Console.WriteLine($"Purchased {command.ToLower()}");
                        break;
                    case "Coke":
                        if (totalMoney < 1)
                        {
                            Console.WriteLine("Sorry, not enough money");
                            break;
                        }
                        totalMoney -= 1;
                        Console.WriteLine($"Purchased {command.ToLower()}");
                        break;
                    default:
                        Console.WriteLine("Invalid product");
                        command = Console.ReadLine();
                        continue;
                }
                command = Console.ReadLine();
            }
            Console.WriteLine($"Change: {totalMoney:f2}");
        }
    }
}
