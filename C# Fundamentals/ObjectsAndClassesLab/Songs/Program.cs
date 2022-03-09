using System;
using System.Collections.Generic;
using System.Linq;

namespace Songs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numOfSongs = int.Parse(Console.ReadLine());


            List<Songs> songs = new List<Songs>();


            for (int i = 0; i < numOfSongs; i++)
            {
                string[] data = Console.ReadLine()
                    .Split("_");

                Songs curr = new Songs();

                curr.TypeList = data[0];
                curr.Name = data[1];
                curr.Time = data[2];

                songs.Add(curr);
            }

            string typeList = Console.ReadLine();
            if (typeList == "all")
            {
                foreach (Songs song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {

                List<Songs> filtered = songs
                    .Where(s => s.TypeList == typeList)
                    .ToList();

                foreach (Songs song in filtered)
                {
                    Console.WriteLine(song.Name);
                }
            }
        }
    }
    class Songs
    {
        public string TypeList;
        public string Name;
        public string Time;
    }
}
