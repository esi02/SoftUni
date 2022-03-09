using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpaceStation.Models.Planets.Contracts;
using SpaceStation.Repositories.Contracts;

namespace SpaceStation.Repositories
{
   public class PlanetRepository : IRepository<IPlanet>
   {
       private List<IPlanet> models = new List<IPlanet>();
       public IReadOnlyCollection<IPlanet> Models => this.models.AsReadOnly();
        public void Add(IPlanet model)
        {
            if (models.All(x => x.Name != model.Name))
            {
                models.Add(model);
            }
        }

        public bool Remove(IPlanet model)
        {
            return models.Remove(model);
        }

        public IPlanet FindByName(string name)
        {
            return models.Find(x => x.Name == name);
        }
    }
}
