using NUnit.Framework;
using System;
using FightingArena;

namespace Tests
{
    public class WarriorTests
    {
        private Warrior warrior;
        private Warrior enemy;
        [SetUp]
        public void Setup()
        {
            warrior = new Warrior("Esi", 5, 50);
            enemy = new Warrior("Enemy", 5, 20);
            
        }

        [Test]
        public void Constructor_InitializeProperties()
        {
            var expectedName = "Esi";
            var expectedDamage = 5;
            var expectedHP = 50;

            var actualName = warrior.Name;
            var actualDamage = warrior.Damage;
            var actualHP = warrior.HP;

            Assert.That(actualName, Is.EqualTo(expectedName));
            Assert.That(actualDamage, Is.EqualTo(expectedDamage));
            Assert.That(actualHP, Is.EqualTo(expectedHP));
        }
        [Test]
        public void Name_PropertyWithNullEmptyWhitespace()
        {
            Assert.Throws<ArgumentException>(() => warrior = new Warrior(null, 5, 50));
            Assert.Throws<ArgumentException>(() => warrior = new Warrior(string.Empty, 5, 50));
            Assert.Throws<ArgumentException>(() => warrior = new Warrior(" ", 5, 50));
        }
        [Test]
        public void Name_PropertyNormally()
        {
            var expectedName = "Esi";
            var actualName = warrior.Name;

            Assert.That(actualName, Is.EqualTo(expectedName));
        }
        [Test]
        public void Damage_PropertyWithZeroOrNegative()
        {
            Assert.Throws<ArgumentException>(() => warrior = new Warrior("Esi", 0, 50));
            Assert.Throws<ArgumentException>(() => warrior = new Warrior("Esi", -1, 50));
        }
        [Test]
        public void Damage_PropertyNormally()
        {
            var expectedDamage = 5;
            var actualDamage = warrior.Damage;

            Assert.That(actualDamage, Is.EqualTo(expectedDamage));
        }
        [Test]
        public void HP_PropertyWithNegative()
        {
            Assert.Throws<ArgumentException>(() => warrior = new Warrior("Esi", 5, -1));
        }
        [Test]
        public void HP_PropertyNormally()
        {
            var expectedHP = 50;
            var actualHP = 50;

            Assert.That(actualHP, Is.EqualTo(expectedHP));
        }
        [Test]
        public void Attack_MethodWithLowerHP()
        {
            warrior = new Warrior("Esi", 5, 20);
            Assert.Throws<InvalidOperationException>(() => warrior.Attack(enemy));
        }
        [Test]
        public void Attack_MethodWithEnemyWithLowerHP()
        {
            Assert.Throws<InvalidOperationException>(() => warrior.Attack(enemy));
        }
        [Test]
        public void Attack_MethodWithStrongerEnemy()
        {
            enemy = new Warrior("Enemy", 70, 20);
            Assert.Throws<InvalidOperationException>(() => warrior.Attack(enemy));
        }
        [Test]
        public void Attack_MethodNormally()
        {
            enemy = new Warrior("Enemy", 5, 40);
            warrior.Attack(enemy);

            var expectedHP = 45;
            var actualHP = warrior.HP;

            Assert.That(actualHP, Is.EqualTo(expectedHP));
        }
        [Test]
        public void Attack_MethodWithBiggerDamage()
        {
            warrior = new Warrior("Esi", 50, 50);
            enemy = new Warrior("Enemy", 5, 31);
            warrior.Attack(enemy);

            var expectedHP = 0;
            var actualHP = enemy.HP;

            Assert.That(actualHP, Is.EqualTo(expectedHP));
        }
        [Test]
        public void Attack_MethodWithSmallerOrEqualDamage()
        {
            //Smaller
            warrior = new Warrior("Esi", 4, 50);
            enemy = new Warrior("Enemy", 5, 31);
            warrior.Attack(enemy);

            var expectedHP = 27;
            var actualHP = enemy.HP;

            Assert.That(actualHP, Is.EqualTo(expectedHP));

            //Equal
            warrior = new Warrior("Esi", 5, 50);
            enemy = new Warrior("Enemy", 5, 31);
            warrior.Attack(enemy);

            expectedHP = 26;
            actualHP = enemy.HP;

            Assert.That(actualHP, Is.EqualTo(expectedHP));
        }

    }
}