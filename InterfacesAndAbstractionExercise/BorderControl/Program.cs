using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Dictionary<string, IBuyer> buyers = new Dictionary<string, IBuyer>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (input.Length == 4)
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string id = input[2];
                    string birthdate = input[3];
                    Citizen citizen = new Citizen(name, age, id, birthdate);
                    if (!buyers.ContainsKey(name))
                    {
                        buyers.Add(name, citizen);
                    }
                }
                else
                {
                    string name = input[0];
                    int age = int.Parse(input[1]);
                    string group = input[2];
                    Rebel rebel = new Rebel(name, age, group);
                    if (!buyers.ContainsKey(name))
                    {
                        buyers.Add(name, rebel);
                    }
                }
            }

            string command = Console.ReadLine();
            int totalFood = 0;

            while (command != "End")
            {
                if (buyers.ContainsKey(command))
                {
                    var buyer = buyers.GetValueOrDefault(command);
                    buyer.BuyFood();
                    if (buyer.GetType().Name == "Citizen")
                    {
                        totalFood += 10;
                    }
                    else
                    {
                        totalFood += 5;
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine(totalFood);
        }
    }
}
