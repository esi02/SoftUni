using NUnit.Framework;

namespace Robots.Tests
{
    using System;
    [TestFixture]
    public class RobotsTests
    {
        private Robot robot;
        private RobotManager robotManager;
        [SetUp]
        public void SetUp()
        {
            robot = new Robot("Robbie", 50);
            robotManager = new RobotManager(5);
        }

        [Test]
        public void Constructor_ShouldInitializeCollectionAndCapacity()
        {
            Assert.IsNotNull(robotManager.Capacity);
            Assert.IsNotNull(robotManager.Count);
        }
        [Test]
        public void Capacity_ShouldThrowExceptionWithNegativeValue()
        {
            Assert.Throws<ArgumentException>(() => robotManager = new RobotManager(-1));
        }
        [Test]
        public void Capacity_ShouldInitializeNormally()
        {
            Assert.IsTrue(robotManager.Capacity == 5);
        }
        [Test]
        public void Count_ShouldReturnNormally()
        {
            robotManager.Add(robot);
            int expectedResult = 1;
            int actualResult = robotManager.Count;

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
        [Test]
        public void Add_ShouldThrowExceptionIfDuplicateRobot()
        {
            robotManager.Add(robot);

            Assert.Throws<InvalidOperationException>(() => robotManager.Add(robot));
        }
        [Test]
        public void Add_ShouldThrowExceptionIfSmallCapacity()
        {
            robotManager = new RobotManager(0);

            Assert.Throws<InvalidOperationException>(() => robotManager.Add(robot));
        }
        [Test]
        public void Add_ShouldAddNormally()
        {
            robotManager.Add(robot);

            Assert.IsTrue(robotManager.Count == 1);
        }
        [Test]
        public void Remove_ShouldThrowExceptionIfNull()
        {
            Assert.Throws<InvalidOperationException>(() => robotManager.Remove("Nonexistent"));
        }
        [Test]
        public void Remove_ShouldRemoveNormally()
        {
            robotManager.Add(robot);
            robotManager.Remove("Robbie");
            int expectedResult = 0;
            int actualResult = robotManager.Count;

            Assert.That(actualResult, Is.EqualTo(expectedResult));
        }
        [Test]
        public void Work_ShouldThrowExceptionIfRobotDoesntExist()
        {
            Assert.Throws<InvalidOperationException>(() => robotManager.Work("Nonexistent", "worker", 10));
        }
        [Test]
        public void Work_ShouldThrowExceptionIfBatteryIsLow()
        {
            robotManager.Add(robot);

            Assert.Throws<InvalidOperationException>(() => robotManager.Work("Robbie", "worker", 60));
        }
        [Test]
        public void Work_ShouldReduceBatteryNormally()
        {
            robotManager.Add(robot);
            robotManager.Charge("Robbie");

            robotManager.Work("Robbie", "worker", 10);

            int expectedBattery = 40;
            int actualBattery = robot.Battery;

            Assert.That(actualBattery, Is.EqualTo(expectedBattery));
        }
        [Test]
        public void Charge_ShouldThrowExceptionIfRobotDoesntExist()
        {
            Assert.Throws<InvalidOperationException>(() => robotManager.Charge("Nonexistent"));
        }
        [Test]
        public void Charge_ShouldChargeNormally()
        {
            robotManager.Add(robot);
            robotManager.Charge("Robbie");

            int expectedBattery = robot.MaximumBattery;
            int actualBattery = robot.Battery;

            Assert.That(actualBattery, Is.EqualTo(expectedBattery));

        }
    }
}
