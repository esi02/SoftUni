using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    public class Team
    {
        private string name;
        private List<Player> players;
        public Team(string name)
        {
            this.Name = name;
            this.Players = new List<Player>();
        }
        public List<Player> Players
        {
            get { return players; }
            set { players = value; }
        }

        public int Rating { get { return CalculateAverageStats(); } }

        public string Name
        {
            get { return name; }
            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("A name should not be empty.");
                }
                name = value;
            }
        }
        public void AddPlayer(Player player)
        {
            Players.Add(player);
        }
        public void RemovePlayer(string playerName)
        {
            if (!Players.Exists(x => x.Name == playerName))
            {
                Console.WriteLine($"Player {playerName} is not in {Name} team.");
            }
            else
            {
                var player = Players.Find(x => x.Name == playerName);
                Players.Remove(player);
            }
        }

        public int CalculateAverageStats()
        {
            if (Players.Count == 0)
            {
                return 0;
            }
            var values = Players.Select(x => x.SkillLevel);
            var average = values.Average();
            return (int)Math.Round(average);
        }
    }
}
