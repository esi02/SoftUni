using NUnit.Framework;
using System;
using CarManager;

namespace Tests
{
    public class CarTests
    {
        private Car car;
        [SetUp]
        public void Setup()
        {
            car = new Car("Renault", "Clio", 1.7, 20);
        }

        [Test]
        public void Constructors_ShouldAddValuesToProperties()
        {
            var expectedMake = "Renault";
            var expectedModel = "Clio";
            var expectedFuelConsump = 1.7;
            var expectedFuelCapacity = 20;
            var expectedFuelAmount = 0;

            Assert.AreEqual(expectedMake, car.Make);
            Assert.AreEqual(expectedModel, car.Model);
            Assert.AreEqual(expectedFuelConsump, car.FuelConsumption);
            Assert.AreEqual(expectedFuelCapacity, car.FuelCapacity);
            Assert.AreEqual(expectedFuelAmount, car.FuelAmount);
        }
        [Test]
        public void Make_PropertyWithNullOrEmpty()
        {
            Assert.Throws<ArgumentException>(() =>
            car = new Car(null, "Clio", 1.7, 20));
            Assert.Throws<ArgumentException>(() =>
            car = new Car(string.Empty, "Clio", 1.7, 20));
            Assert.IsTrue(car.Make == "Renault");
        }
        [Test]
        public void Make_PropertyNormally()
        {
            var expectedMake = "Renault";
            var actualMake = car.Make;
            Assert.That(actualMake, Is.EqualTo(expectedMake));
        }
        [Test]
        public void Model_PropertyWithNullOrEmpty()
        {
            Assert.Throws<ArgumentException>(() =>
            car = new Car("Renault", null, 1.7, 20));
            Assert.Throws<ArgumentException>(() =>
            car = new Car("Renault", string.Empty, 1.7, 20));
            Assert.IsTrue(car.Model == "Clio");
        }
        [Test]
        public void Model_PropertyNormally()
        {
            var expectedModel = "Clio";
            var actualModel = car.Model;
            Assert.That(actualModel, Is.EqualTo(expectedModel));
        }
        [Test]
        public void FuelConsumption_PropertyWithNegativeOrZero()
        {
            Assert.Throws<ArgumentException>(() =>
            car = new Car("Renault", "Clio", 0, 20));
            Assert.Throws<ArgumentException>(() =>
            car = new Car("Renault", "Clio", -1, 20));
        }
        [Test]
        public void FuelConsumption_PropertyNormally()
        {
            var expectedFuelConsum = 1.7;
            var actualFuelConsum = car.FuelConsumption;
            Assert.That(actualFuelConsum, Is.EqualTo(expectedFuelConsum));
        }
        [Test]
        public void FuelAmount_PropertyWithNegative()
        {
            Assert.IsFalse(car.FuelAmount < 0);
        }
        [Test]
        public void FuelCapacity_PropertyWithNegativeOrZero()
        {
            Assert.Throws<ArgumentException>(() =>
            car = new Car("Renault", "Clio", 1.7, 0));
            Assert.Throws<ArgumentException>(() =>
            car = new Car("Renault", "Clio", 1.7, -1));
        }
        [Test]
        public void FuelCapacity_PropertyNormally()
        {
            var expectedFuelCapacity = 20;
            var actualFuelCapacity = car.FuelCapacity;
            Assert.That(actualFuelCapacity, Is.EqualTo(expectedFuelCapacity));
        }
        [Test]
        public void Refuel_MethodWithNegativeOrZero()
        {
            Assert.Throws<ArgumentException>(() => car.Refuel(-1));
            Assert.Throws<ArgumentException>(() => car.Refuel(0));
        }
        [Test]
        public void Refuel_MethodNormally()
        {
            car.Refuel(10);
            var expectedFuelAmount = 10;
            var actualFuelAmounnt = car.FuelAmount;
            Assert.That(actualFuelAmounnt, Is.EqualTo(expectedFuelAmount));
        }
        [Test]
        public void Refuel_MethodMoreThanItsCapacity()
        {
            car.Refuel(30);
            var expectedFuelAmount = 20;
            var actualFuelAmounnt = car.FuelAmount;
            Assert.That(actualFuelAmounnt, Is.EqualTo(expectedFuelAmount));
        }
        [Test]
        public void Drive_MethodWithNotEnoughFuel()
        {
            Assert.Throws<InvalidOperationException>(() => car.Drive(2000));
        }
        [Test]
        public void Drive_MethodNormally()
        {
            car.Refuel(20);
            car.Drive(300);
            var expectedFuelAmount = 14.9;
            var actualFuelAmount = car.FuelAmount;
            Assert.That(actualFuelAmount, Is.EqualTo(expectedFuelAmount));
        }
    }
}