using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using SpaceStation.Models.Planets.Contracts;

namespace SpaceStation.Models.Planets
{
    public class Planet : IPlanet
    {
        private string name;
        private List<string> items;

        public Planet(string name)
        { 
            this.Name = name;
            this.items = new List<string>();
        }
        public ICollection<string> Items => this.items;

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentNullException(Utilities.Messages.ExceptionMessages.InvalidPlanetName);
                }

                this.name = value;
            }
        }
    }
}
