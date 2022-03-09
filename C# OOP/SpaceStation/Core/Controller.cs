using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpaceStation.Core.Contracts;
using SpaceStation.Models.Astronauts;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission;
using SpaceStation.Models.Planets;
using SpaceStation.Repositories;
using SpaceStation.Utilities.Messages;

namespace SpaceStation.Core
{
    public class Controller : IController
    {
        private List<string> astronautTypes = new List<string>()
        {
            "Astronaut",
            "Biologist",
            "Geodesist",
            "Meteorologist",
            "IAstronaut"
        };

        private AstronautRepository astronauts;
        private PlanetRepository planets;
        private int exploredPlanetsCount;

        public Controller()
        {
            astronauts = new AstronautRepository();
            planets = new PlanetRepository();
        }
        public string AddAstronaut(string type, string astronautName)
        {
            if (astronautTypes.All(x => x != type))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InvalidAstronautType));
            }

            Astronaut astronaut = null;

            if (type == "Biologist")
            {
                astronaut = new Biologist(astronautName);
            }
            else if (type == "Geodesist")
            {
                astronaut = new Geodesist(astronautName);
            }
            else if (type == "Meteorologist")
            {
                astronaut = new Meteorologist(astronautName);
            }

            astronauts.Add(astronaut);

            return string.Format(OutputMessages.AstronautAdded, type, astronautName);
        }

        public string AddPlanet(string planetName, params string[] items)
        {
            Planet planet = new Planet(planetName);

            foreach (var item in items)
            {
                planet.Items.Add(item);
            }

            planets.Add(planet);

            return string.Format(OutputMessages.PlanetAdded, planetName);
        }

        public string RetireAstronaut(string astronautName)
        {
            if (astronauts.Models.All(x => x.Name != astronautName))
            {
                throw new InvalidOperationException(string.Format(ExceptionMessages.InvalidRetiredAstronaut, astronautName));
            }

            astronauts.Remove(astronauts.Models.First(x => x.Name == astronautName));

            return string.Format(OutputMessages.AstronautRetired, astronautName);
        }

        public string ExplorePlanet(string planetName)
        {
            var suitableAstronauts = astronauts.Models.Where(x => x.Oxygen > 60).ToList();

            if (suitableAstronauts == null || suitableAstronauts.Count == 0)
            {
                throw new InvalidOperationException(ExceptionMessages.InvalidAstronautCount);
            }

            var planet = planets.Models.First(x => x.Name == planetName);
            int deadAstronautsCount = 0;

            Mission mission = new Mission();
            mission.Explore(planet, suitableAstronauts);

            foreach (var astronaut in suitableAstronauts)
            {
                if (astronaut.Oxygen <= 0)
                {
                    deadAstronautsCount++;
                }
            }

            exploredPlanetsCount++;
            return string.Format(OutputMessages.PlanetExplored, planetName, deadAstronautsCount);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{exploredPlanetsCount} planets were explored!");
            sb.AppendLine("Astronauts info:");

            foreach (var astronaut in astronauts.Models)
            {
                sb.AppendLine($"Name: {astronaut.Name}");
                sb.AppendLine($"Oxygen: {astronaut.Oxygen}");
                if (astronaut.Bag.Items.Count == 0)
                {
                    sb.AppendLine("Bag items: none");
                }
                else
                {
                    sb.AppendLine($"Bag items: {string.Join(", ", astronaut.Bag.Items)}");
                }
            }

            return sb.ToString().TrimEnd();
        }
    }
}
