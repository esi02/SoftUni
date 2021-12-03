using System;
using System.Collections.Generic;
using System.Text;
using CarRacing.Models.Cars.Contracts;
using CarRacing.Utilities.Messages;

namespace CarRacing.Models.Cars
{
    public abstract class Car : ICar
    {
        private string _make;
        private string _model;
        private string _vin;
        private int _horsePower;
        private double _fuelAvailable;
        private double _fuelConsumptionPerRace;

        public Car(string make, string model, string VIN, int horsePower, double fuelAvailable, double fuelConsumptionPerRace)
        {
            this.Make = make;
            this.Model = model;
            this.VIN = VIN;
            this.HorsePower = horsePower;
            this.FuelAvailable = fuelAvailable;
            this.FuelConsumptionPerRace = fuelConsumptionPerRace;
        }
        public string Make
        {
            get => this._make;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCarMake);
                }

                this._make = value;
            }
        }

        public string Model
        {
            get => this._model;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCarModel);
                }

                this._model = value;
            }
        }

        public string VIN
        {
            get => this._vin;
            private set
            {
                if (value.Length != 17)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCarVIN);
                }

                this._vin = value;
            }
        }

        public int HorsePower
        {
            get => this._horsePower;
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCarHorsePower);
                }

                this._horsePower = value;
            }
        }

        public double FuelAvailable
        {
            get => _fuelAvailable;
            private set
            {
                _fuelAvailable = value;
                if (_fuelAvailable < 0)
                {
                    _fuelAvailable = 0;
                }

            }
        }

        public double FuelConsumptionPerRace
        {
            get => _fuelConsumptionPerRace;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidCarFuelConsumption);
                }

                _fuelConsumptionPerRace = value;
            }
        }
        public virtual void Drive()
        {
            FuelAvailable -= FuelConsumptionPerRace;
        }
    }
}
