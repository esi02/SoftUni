using System;
using System.Linq;

namespace MuOnline
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] rooms = Console.ReadLine()
                .Split("|", StringSplitOptions.RemoveEmptyEntries);

            int currentHealth = 100;
            int foundCoins = 0;
            int attack = 0;


            for (int i = 0; i < rooms.Length; i++)
            {
                string[] roomsArgs = rooms[i].Split(" ", StringSplitOptions.RemoveEmptyEntries);

                if (roomsArgs[0] == "potion")
                {
                    int healed = int.Parse(roomsArgs[1]);
                    if (currentHealth < 100)
                    {
                        currentHealth += healed;
                        if (currentHealth > 100)
                        {
                            currentHealth -= healed;
                            healed = 100 - currentHealth;
                            currentHealth += healed;
                            Console.WriteLine($"You healed for {healed} hp.");
                            Console.WriteLine($"Current health: {currentHealth} hp.");
                            continue;
                        }
                        Console.WriteLine($"You healed for {healed} hp.");
                        Console.WriteLine($"Current health: {currentHealth} hp.");
                        continue;
                    }
                }
                if (roomsArgs[0] == "chest")
                {
                    int currentFoundCoins = int.Parse(roomsArgs[1]);
                    Console.WriteLine($"You found {currentFoundCoins} bitcoins.");
                    foundCoins += currentFoundCoins;
                }
                else
                {
                    string currentMonster = roomsArgs[0];
                    attack = int.Parse(roomsArgs[1]);
                    currentHealth -= attack;
                    if (currentHealth <= 0)
                    {
                        Console.WriteLine($"You died! Killed by {currentMonster}.");
                        Console.WriteLine($"Best room: {i + 1}");
                        return;
                    }
                    else
                    {
                        Console.WriteLine($"You slayed {currentMonster}.");
                    }
                }
            }
            Console.WriteLine("You've made it!");
            Console.WriteLine($"Bitcoins: {foundCoins}");
            Console.WriteLine($"Health: {currentHealth}");
        }
    }
}
