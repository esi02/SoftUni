using NUnit.Framework;
using System;

namespace Tests
{
    public class ExtendedDatabaseTests
    {
        private Person person1;
        private Person person2;
        private ExtendedDatabase extended;
        [SetUp]
        public void Setup()
        {
            person1 = new Person(0000003333, "Esi");
            person2 = new Person(1111113333, "Husein");
            extended = new ExtendedDatabase(new Person[] { person1, person2 });
        }

        [Test]
        public void Constructor_InitializeCollection()
        {
            var expected = new Person[] { person1, person2 };
            var ex = new ExtendedDatabase(expected);
            var expectedCount = ex.Count;
            var actual = new Person[] { extended.FindById(0000003333), extended.FindById(1111113333) };
            var actualCount = extended.Count;
            Assert.That(actual, Is.EqualTo(expected));
            Assert.That(actualCount, Is.EqualTo(expectedCount));
            Assert.That(extended, Is.EqualTo(ex));
        }
        [Test]
        public void Add_WithSameUsername()
        {
            var samePerson = new Person(8594944, "Esi");
            Assert.Throws<InvalidOperationException>(() => extended.Add(samePerson));
        }
        [Test]
        public void Add_WithSameID()
        {
            var samePerson = new Person(0000003333, "Other");
            Assert.Throws<InvalidOperationException>(() => extended.Add(samePerson));
        }
        [Test]
        public void Add_OnlyUntil16()
        {
            Person[] people = new Person[] {
            new Person(635645, "Ot645her"),
            new Person(3564564, "Ot65645her"),
           new Person(645, "654634"),
           new Person(589348994, "gfdggb"),
           new Person(65465, "tdtydhj"),
           new Person(5374454554, "zgdfgtr"),
           new Person(764566475, "ersgfbv"),
           new Person(24365757, "afesgf"),
           new Person(43567345, "dasefdgtrfhg"),
            new Person(23456789, "dsefgrtfhg"),
            new Person(874587958969856, "ifdhaerbhjgbj"),
            new Person(54775487934, "fkjhfhjfr"),
            new Person(83483487934, "grhrhu"),
            new Person(5555555, "retfgbv"),
            new Person(3333333, "eeeeeeeee"),
            new Person(88888888, "ppppppppp")
        };
            var pp = new Person(444444444, "rrrrrrrrr");
            extended = new ExtendedDatabase(people);
            Assert.Throws<InvalidOperationException>(() => extended.Add(pp));
        }
        [Test]
        public void DontRemoveFromEmptyArray()
        {
            extended.Remove();
            extended.Remove();
            Assert.Throws<InvalidOperationException>(() => extended.Remove());
        }
        [Test]
        public void FindByUsername()
        {
            Assert.Throws<ArgumentNullException>(() => extended.FindByUsername(null));
            Assert.Throws<ArgumentNullException>(() => extended.FindByUsername(string.Empty));
            Assert.Throws<InvalidOperationException>(() => extended.FindByUsername("Dqdo"));
        }
        [Test]
        public void FindByID()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => extended.FindById(-1));
            Assert.Throws<InvalidOperationException>(() => extended.FindById(4738347));
        }
    }
}