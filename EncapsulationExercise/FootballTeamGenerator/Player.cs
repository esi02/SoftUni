using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FootballTeamGenerator
{
    public class Player
    {
        private string name;
        private double skillLevel;
        private int endurance;
        private int sprint;
        private int dribble;
        private int passing;
        private int shooting;
        public double SkillLevel
        {
            get => this.skillLevel;
            private set
            {
                this.skillLevel = value;
            }
        }

        public int Endurance
        {
            get => this.endurance;
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new Exception($"Endurance should be between 0 and 100.");
                }
                endurance = value;
            }
        }
        public int Sprint
        {
            get => this.sprint;
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new Exception($"Sprint should be between 0 and 100.");
                }
                sprint = value;
            }
        }
        public int Dribble
        {
            get => this.dribble;
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new Exception($"Dribble should be between 0 and 100.");
                }
                dribble = value;
            }
        }
        public int Passing
        {
            get => this.passing;
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new Exception($"Passing should be between 0 and 100.");
                }
                passing = value;
            }
        }
        public int Shooting
        {
            get => this.shooting;
            private set
            {
                if (value < 0 || value > 100)
                {
                    throw new Exception($"Shooting should be between 0 and 100.");
                }
                shooting = value;
            }
        }
        public Player(string name, int endurance, int sprint, int dribble, int passing, int shooting)
        {
            this.Name = name;
            this.Endurance = endurance;
            this.Sprint = sprint;
            this.Dribble = dribble;
            this.Passing = passing;
            this.Shooting = shooting;
            var statsAverage = new int[] { Endurance, Dribble, Passing, Shooting, Sprint };
            this.SkillLevel = statsAverage.Average();
        }
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

    }
}
