using System;
using FakeAxeAndDummy;

// Axe durability drop with 5 
public class Axe : IWeapon
{
    public Axe(int attack, int durability)
    {
        this.attackPoints = attack;
        this.durabilityPoints = durability;
    }
    public void Attack(Dummy target)
    {
        if (this.durabilityPoints <= 0)
        {
            throw new InvalidOperationException("Axe is broken.");
        }

        target.TakeAttack(this.attackPoints);
        this.durabilityPoints -= 1;
    }

    public int durabilityPoints { get; private set; }
    public int attackPoints { get; private set; }
}
