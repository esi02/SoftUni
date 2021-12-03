using System;
using System.Linq;

namespace HeartDelivery
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] houses = Console.ReadLine()
                .Split("@")
                .Select(int.Parse)
                .ToArray();

            string []command = Console.ReadLine()
                .Split()
                .ToArray();
            int jumpIndex = 0;
            int currentIndex = 0;

            while (command[0] != "Love!")
            {
                jumpIndex = int.Parse(command[1]);
                currentIndex += jumpIndex;
                if (currentIndex >= houses.Length)
                {
                    currentIndex = 0;
                }
                if (houses[currentIndex] != 0)
                {
                    houses[currentIndex] -= 2;
                    if (houses[currentIndex] == 0)
                    {
                        Console.WriteLine($"Place {currentIndex} has Valentine's day.");
                    }
                }
                else
                {
                    Console.WriteLine($"Place {currentIndex} already had Valentine's day.");
                }
                command = Console.ReadLine()
               .Split()
               .ToArray();
            }
            Console.WriteLine($"Cupid's last position was {currentIndex}.");
            bool allHadValentinesDay = false;

            if (houses.All(x => houses.Equals(0)))
            {
                allHadValentinesDay = true;
            }

            if (allHadValentinesDay)
            {
                Console.WriteLine("Mission was successful.");
            }
            else
            {
                int counter = 0;
                for (int i = 0; i < houses.Length; i++)
                {
                    if (houses[i] != 0)
                    {
                        counter++;
                    }
                }
                Console.WriteLine($"Cupid has failed {counter} places.");
            }
        }
    }
}
