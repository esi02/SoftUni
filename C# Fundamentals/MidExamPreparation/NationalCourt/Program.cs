using System;

namespace NationalCourt
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstPeoplePerHour = int.Parse(Console.ReadLine());
            int secondPeoplePerHour = int.Parse(Console.ReadLine());
            int thirdPeoplePerHour = int.Parse(Console.ReadLine());
            int totalPeople = int.Parse(Console.ReadLine());

            int hoursCounter = 0;
            int peopleAnsweredPerHour = firstPeoplePerHour + secondPeoplePerHour + thirdPeoplePerHour;

            while (totalPeople > 0)
            {
                hoursCounter++;
                if (hoursCounter % 4 == 0)
                {
                    continue;
                }
                totalPeople -= peopleAnsweredPerHour;
                if (totalPeople < 0)
                {
                    totalPeople += peopleAnsweredPerHour;
                    totalPeople = 0;
                }
            }
            Console.WriteLine($"Time needed: {hoursCounter}h.");
        }
    }
}
