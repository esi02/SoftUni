using System;
using System.Linq;
using NUnit.Framework;

[TestFixture]
public class HeroRepositoryTests
{
    private HeroRepository repository;
    private Hero hero;
    [SetUp]
    public void TestsSetup()
    {
        repository = new HeroRepository();
        hero = new Hero("Superman", 5);
    }

    [Test]
    public void Constructor_ShouldInitializeCollection()
    {
        Assert.IsNotNull(repository.Heroes);
    }
    [Test]
    public void CreateMethod_ShouldThrowExceptionWithNullHero()
    {
        hero = null;

        Assert.Throws<ArgumentNullException>(() => repository.Create(hero));
    }
    [Test]
    public void CreateMethod_ShouldThrowExceptionWithDuplicateName()
    {
        repository.Create(hero);
        Hero duplicateHero = new Hero("Superman", 4);

        Assert.Throws<InvalidOperationException>(() => repository.Create(duplicateHero));
    }
    [Test]
    public void CreateMethod_ShouldAddValidHeroAndReturnString()
    {
        string expectedResult = $"Successfully added hero {hero.Name} with level {hero.Level}";
        string actualResult = repository.Create(hero);

        Assert.IsTrue(repository.Heroes.Contains(hero));
        Assert.That(actualResult, Is.EqualTo(expectedResult));
    }
    [Test]
    [TestCase(null)]
    [TestCase(" ")]
    [TestCase("")]
    public void RemoveMethod_ShouldThrowExceptionWithNullOrWhitespaceString(string name)
    {
        Assert.Throws<ArgumentNullException>(() => repository.Remove(name));
    }
    [Test]
    public void RemoveMethod_ShouldRemoveHeroSuccessfully()
    {
        repository.Create(hero);
        Assert.IsTrue(repository.Remove("Superman"));
    }
    [Test]
    public void RemoveMethod_ShouldNotRemoveHero()
    {
        Assert.IsFalse(repository.Remove("Superman"));
    }
    [Test]
    public void GetHeroWithHighestLevelMethod_ShouldReturnHero()
    {
        Hero secondHero = new Hero("Batman", 8);
        repository.Create(hero);
        repository.Create(secondHero);

        Hero expectedHero = secondHero;
        Hero actualHero = repository.GetHeroWithHighestLevel();

        Assert.That(actualHero, Is.EqualTo(expectedHero));
    }
    [Test]
    public void GetHero_ShouldReturnHero()
    {
        repository.Create(hero);
        Hero expectedHero = hero;
        Hero actualHero = repository.GetHero("Superman");

        Assert.That(actualHero, Is.EqualTo(expectedHero));
    }
    [Test]
    public void GetHero_ShouldReturnNullIfHeroDoesntExist()
    {
        Hero actualHero = repository.GetHero("Superman");

        Assert.IsNull(actualHero);
    }
}