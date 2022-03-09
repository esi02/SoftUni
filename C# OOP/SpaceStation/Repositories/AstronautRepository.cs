using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SpaceStation.Models.Astronauts;
using SpaceStation.Models.Astronauts.Contracts;
using SpaceStation.Repositories.Contracts;

namespace SpaceStation.Repositories
{
    public class AstronautRepository : IRepository<IAstronaut>
    {
        private List<IAstronaut> models;

        public IReadOnlyCollection<IAstronaut> Models => this.models.AsReadOnly();

        public AstronautRepository()
        {
            this.models = new List<IAstronaut>();
        }

        public void Add(IAstronaut model)
        {
            if (models.All(x => x.Name != model.Name))
            {
                models.Add(model);
            }
        }

        public IAstronaut FindByName(string name)
        {
            if (!models.Exists(x => x.Name == name))
            {
                return null;
            }
            return models.Find(x => x.Name == name);
        }

        public bool Remove(IAstronaut model)
        {
            return models.Remove(model);
        }
    }
}
