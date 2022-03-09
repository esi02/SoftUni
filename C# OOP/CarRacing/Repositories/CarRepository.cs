using System;
using System.Collections.Generic;
using System.Text;
using CarRacing.Models.Cars;
using CarRacing.Models.Cars.Contracts;
using CarRacing.Repositories.Contracts;
using CarRacing.Utilities.Messages;


namespace CarRacing.Repositories
{
    public class CarRepository : IRepository<ICar>
    {
        private List<ICar> _models;
        public IReadOnlyCollection<ICar> Models => _models;

        public CarRepository()
        {
            _models = new List<ICar>();
        }
        public void Add(ICar model)
        {
            if (model == null)
            {
                throw new ArgumentException(ExceptionMessages.InvalidAddCarRepository);
            }

            if (!_models.Exists(x => x.VIN == model.VIN))
            {
                _models.Add(model);
            }
        }

        public bool Remove(ICar model)
        {
            return _models.Remove(model);
        }

        public ICar FindBy(string property)
        {
            return _models.Find(x => x.VIN == property);
        }
    }
}
