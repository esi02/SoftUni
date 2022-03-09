using NUnit.Framework;
using Moq;

[TestFixture]
public class HeroTests
{
    private Mock<Hero> hero;
    private Mock<Dummy> target;
    [SetUp]
    public void Start()
    {
        hero = new Mock<Hero>("Esi");
        target = new Mock<Dummy>(5, 5);
    }

    [Test]
    public void HeroGainsXPWhenTargetDies()
    {
        hero.Object.Attack(target.Object);
        Assert.IsTrue(hero.Object.Experience == target.Object.GiveExperience());
    }
}