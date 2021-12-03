using System;
using System.Collections.Generic;
using System.Text;
using CarRacing.Models.Cars.Contracts;
using CarRacing.Models.Racers.Contracts;
using CarRacing.Utilities.Messages;

namespace CarRacing.Models.Racers
{
    public abstract class Racer : IRacer
    {
        private string _username;
        private string _racingBehavior;
        private int _drivingExperience;
        private ICar _car;

        public Racer(string username, string racingBehavior, int drivingExperience, ICar car)
        {
            this.Username = username;
            this.RacingBehavior = racingBehavior;
            this.DrivingExperience = drivingExperience;
            this.Car = car;
        }
        public string Username
        {
            get => _username;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidRacerName);
                }

                _username = value;
            }
        }

        public string RacingBehavior
        {
            get => _racingBehavior;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidRacerBehavior);
                }

                _racingBehavior = value;
            }
        }

        public int DrivingExperience
        {
            get => _drivingExperience;
            protected set
            {
                _drivingExperience = value;
                if (value < 0 || value > 100)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidRacerDrivingExperience);
                }

            }
        }

        public ICar Car
        {
            get => _car;
            private set
            {
                if (value == null)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidRacerCar);
                }

                _car = value;
            }
        }
        public virtual void Race()
        {
            Car.Drive();
        }

        public bool IsAvailable()
        {
            return Car.FuelAvailable >= Car.FuelConsumptionPerRace;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{this.GetType().Name}: {this.Username}");
            sb.AppendLine($"--Driving behavior: {this.RacingBehavior}");
            sb.AppendLine($"--Driving experience: {this.DrivingExperience}");
            sb.AppendLine($"--Car: {Car.Make} {Car.Model} ({Car.VIN})");

            return sb.ToString().TrimEnd();
        }
    }
}
