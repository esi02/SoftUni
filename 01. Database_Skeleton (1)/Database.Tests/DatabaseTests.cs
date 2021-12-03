using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class DatabaseTests
    {
        private Database data;
        [SetUp]
        public void Setup()
        {
            data = new Database(new int[] { 1, 2, 3 });
        }

        [Test]
        public void ConstructorIsIntegerAndStores()
        {
            var elements = data.Fetch();
            bool isInt = elements.GetType().GetElementType() == typeof(int);
            var actual = data.Count;
            Assert.That(actual, Is.EqualTo(3));
            Assert.IsTrue(isInt);
        }
        [Test]
        public void ArrayCapacityIsNot16IntegersLong()
        {
            int[] elements = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17 };
            Assert.Throws<InvalidOperationException>(() => data = new Database(elements));

        }
        [Test]
        public void AddOnlyUntil16Elements()
        {
            data.Add(1);
            var elements = data.Fetch();
            var expected = elements[data.Count - 1] != 0;
            Assert.True(expected);
            data = new Database(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16 });
            Assert.Throws<InvalidOperationException>(() => data.Add(1));
        }
        [Test]
        public void DontRemoveFromEmptyArray()
        {
            data.Remove();
            data.Remove();
            data.Remove();
            Assert.Throws<InvalidOperationException>(() => data.Remove());
        }
        [Test]
        public void FetchReturnArray()
        {
            var elements = data.Fetch();
            bool isArray = elements.GetType().IsArray == true;
            Assert.IsTrue(isArray);
        }
    }
}