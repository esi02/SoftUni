using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using SpaceStation.Models.Astronauts;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Models.Mission.Contracts;
using SpaceStation.Models.Planets;
using SpaceStation.Models.Planets.Contracts;

namespace SpaceStation.Models.Mission
{
    public class Mission : IMission
    {
        public void Explore(IPlanet planet, ICollection<IAstronaut> astronauts)
        {
            int astronautsIndex = 0;
            for (int i = 0; i < planet.Items.Count; i = 0)
            {
                var currentItem = planet.Items.ElementAt(i);
                var currentAstr = astronauts.ElementAt(astronautsIndex) as Astronaut;

                currentAstr.Breath();

                currentAstr.Bag.Items.Add(currentItem);
                planet.Items.Remove(currentItem);

                if (currentAstr.Oxygen <= 0)
                {
                    astronautsIndex++;
                }

            }
        }
    }
}
