using System;
using System.Collections.Generic;
using System.Text;
using CarRacing.Models.Racers;
using CarRacing.Models.Racers.Contracts;
using CarRacing.Repositories.Contracts;
using CarRacing.Utilities.Messages;

namespace CarRacing.Repositories
{
    public class RacerRepository : IRepository<IRacer>
    {
        private List<IRacer> _models;
        public IReadOnlyCollection<IRacer> Models => _models;

        public RacerRepository()
        {
            _models = new List<IRacer>();
        }
        public void Add(IRacer model)
        {
            if (model == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidAddRacerRepository);
            }

            if (!_models.Exists(x => x.Username == model.Username))
            {
                _models.Add(model);
            }
        }

        public bool Remove(IRacer model)
        {
            return _models.Remove(model);
        }

        public IRacer FindBy(string property)
        {
            return _models.Find(x => x.Username == property);
        }
    }
}
