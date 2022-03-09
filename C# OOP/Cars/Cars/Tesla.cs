using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    public class Tesla : ICar, IElectricCar
    {
        private int battery;
        private string model;
        private string color;
        public int Battery { get => this.battery; set => this.battery = value; }
        public string Model { get => this.model; set => this.model = value; }
        public string Color { get => this.color; set => this.color = value; }
        public Tesla(string model, string color, int batteries)
        {
            this.Model = model;
            this.Color = color;
            this.Battery = batteries;
        }

        public string Start()
        {
            return "Engine start";
        }

        public string Stop()
        {
            return "Breaaak!";
        }
        public override string ToString()
        {
            return $"{Color} Tesla {Model} with {Battery} Batteries" + Environment.NewLine + Start() + Environment.NewLine + Stop();
        }
    }
}
