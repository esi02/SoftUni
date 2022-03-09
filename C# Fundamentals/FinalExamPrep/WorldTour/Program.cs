using System;
using System.Linq;

namespace WorldTour
{
    class Program
    {
        static void Main(string[] args)
        {
            string stops = Console.ReadLine();
            string command = Console.ReadLine();

            while (command != "Travel")
            {
                string[] commandArgs = command.Split(":", StringSplitOptions.RemoveEmptyEntries);
                string action = commandArgs[0];

                if (action == "Add Stop")
                {
                    int index = int.Parse(commandArgs[1]);
                    string toInsert = commandArgs[2];

                    if (index >= 0 && index < stops.Length)
                    {
                        stops = stops.Insert(index, toInsert);
                    }
                    Console.WriteLine(stops);
                }
                else if (action == "Remove Stop")
                {
                    int startIndex = int.Parse(commandArgs[1]);
                    int endIndex = int.Parse(commandArgs[2]);

                    if (startIndex >= 0 && startIndex < stops.Length
                        && endIndex >= 0 && endIndex < stops.Length)
                    {
                        int count = (endIndex - startIndex) + 1;
                        stops = stops.Remove(startIndex, count);
                    }
                    Console.WriteLine(stops);
                }
                else
                {
                    string oldString = commandArgs[1];
                    string newString = commandArgs[2];

                    if (stops.Contains(oldString))
                    {
                        stops = stops.Replace(oldString, newString);
                    }
                    Console.WriteLine(stops);
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"Ready for world tour! Planned stops: {stops}");
        }
    }
}
