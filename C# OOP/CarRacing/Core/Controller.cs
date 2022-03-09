using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using CarRacing.Core.Contracts;
using CarRacing.Models.Cars;
using CarRacing.Models.Cars.Contracts;
using CarRacing.Models.Maps;
using CarRacing.Models.Maps.Contracts;
using CarRacing.Models.Racers;
using CarRacing.Models.Racers.Contracts;
using CarRacing.Repositories;
using CarRacing.Repositories.Contracts;
using CarRacing.Utilities.Messages;

namespace CarRacing.Core
{
    public class Controller : IController
    {
        private IRepository<ICar> _carRepository = new CarRepository();
        private IRepository<IRacer> _racerRepository = new RacerRepository();
        public string AddCar(string type, string make, string model, string VIN, int horsePower)
        {
            if (type == "SuperCar")
            {
                var car = new SuperCar(make, model, VIN, horsePower);
                _carRepository.Add(car);
                return string.Format(OutputMessages.SuccessfullyAddedCar, make, model, VIN);
            }

            if (type == "TunedCar")
            {
                var car = new TunedCar(make, model, VIN, horsePower);
                _carRepository.Add(car);
                return string.Format(OutputMessages.SuccessfullyAddedCar, make, model, VIN);
            }

            throw new ArgumentException(ExceptionMessages.InvalidCarType);

        }

        public string AddRacer(string type, string username, string carVIN)
        {
            var car = _carRepository.FindBy(carVIN);
            if (car == null)
            {
                throw new ArgumentException(ExceptionMessages.CarCannotBeFound);
            }

            if (type == "ProfessionalRacer")
            {
                var racer = new ProfessionalRacer(username, car);
                _racerRepository.Add(racer);
                return string.Format(OutputMessages.SuccessfullyAddedRacer, racer.Username);
            }

            if (type == "StreetRacer")
            {
                var racer = new StreetRacer(username, car);
                _racerRepository.Add(racer);
                return string.Format(OutputMessages.SuccessfullyAddedRacer, racer.Username);
            }

            throw new ArgumentException(ExceptionMessages.InvalidRacerType);
        }

        public string BeginRace(string racerOneUsername, string racerTwoUsername)
        {
            var racerOne = _racerRepository.FindBy(racerOneUsername);
            var racerTwo = _racerRepository.FindBy(racerTwoUsername);

            if (racerOne == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.RacerCannotBeFound, racerOneUsername));
            }

            if (racerTwo == null)
            {
                throw new ArgumentException(string.Format(ExceptionMessages.RacerCannotBeFound, racerTwoUsername));
            }

            IMap map = new Map();
            return map.StartRace(racerOne, racerTwo);
        }

        public string Report()
        {
            StringBuilder sb = new StringBuilder();
            var ordered = _racerRepository.Models.OrderByDescending(x => x.DrivingExperience).ThenBy(x => x.Username);

            foreach (var racer in ordered)
            {
                sb.AppendLine(racer.ToString());
            }

            return sb.ToString().TrimEnd();
        }
    }
}
