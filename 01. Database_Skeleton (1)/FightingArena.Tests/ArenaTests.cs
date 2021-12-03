using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using FightingArena;

namespace Tests
{
    public class ArenaTests
    {
        private Arena arena;
        private Warrior warrior;
        private Warrior enemy;
        [SetUp]
        public void Setup()
        {
            arena = new Arena();
            warrior = new Warrior("Esi", 5, 50);
            enemy = new Warrior("Enemy", 3, 40);
        }

        [Test]
        public void Constructor_InitializeCollection()
        {
            Assert.IsNotNull(arena.Warriors);
        }
        [Test]
        public void Collection_PropertyReturnsList()
        {
            var expectedReturn = new List<Warrior>();
            var actualReturn = arena.Warriors;

            Assert.That(actualReturn, Is.EqualTo(expectedReturn));
        }
        [Test]
        public void Count_PropertyReturnsInt()
        {
            var expectedReturn = 0;
            var actualReturn = arena.Count;

            Assert.That(actualReturn, Is.EqualTo(expectedReturn));
        }
        [Test]
        public void Enroll_MethodWithExistingWarrior()
        {
            arena.Enroll(warrior);
            var warriorCopy = new Warrior(warrior.Name, warrior.Damage, warrior.HP);
            Assert.Throws<InvalidOperationException>(() => arena.Enroll(warriorCopy));
            Assert.Throws<InvalidOperationException>(() => arena.Enroll(warrior));
        }
        [Test]
        public void Enroll_MethodNormally()
        {
            arena.Enroll(warrior);
            Assert.That(arena.Warriors, Has.Member(warrior));
        }
        [Test]
        public void Fight_MethodWithNullDefender()
        {
            Assert.Throws<InvalidOperationException>(() => arena.Fight("Esi", "Husein"));
        }
        [Test]
        public void Fight_MethodWithNullAttacker()
        {
            Assert.Throws<InvalidOperationException>(() => arena.Fight("Husein", "Esi"));
        }
        [Test]
        public void Fight_MethodNormally()
        {
            arena.Enroll(enemy);
            arena.Enroll(warrior);
            int expectedAttackerHP = warrior.HP - enemy.Damage;
            int expectedDefenderHP = enemy.HP - warrior.Damage;
            arena.Fight(warrior.Name, enemy.Name);

            Assert.AreEqual(expectedAttackerHP, warrior.HP);
            Assert.AreEqual(expectedDefenderHP, enemy.HP);
        }
    }
}
