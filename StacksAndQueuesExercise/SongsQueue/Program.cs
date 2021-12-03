using System;
using System.Collections.Generic;

namespace SongsQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sequence = Console.ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries);

            Queue<string> songs = new Queue<string>(sequence);

            while (songs.Count > 0)
            {
                string[] commands = Console.ReadLine().Split(new[] { ' ' }, 2);
                string action = commands[0];

                switch (action)
                {
                    case "Play":
                        songs.Dequeue();
                        break;
                    case "Add":
                        string song = commands[1];
                        if (!songs.Contains(song))
                        {
                            songs.Enqueue(song);
                        }
                        else
                        {
                            Console.WriteLine($"{song} is already contained!");
                        }
                        break;
                    case "Show":
                        Console.WriteLine(string.Join(", ", songs));
                        break;
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
