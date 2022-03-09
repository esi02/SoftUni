using System;
using FakeAxeAndDummy;

public class Dummy : ITarget
{
    public Dummy(int health, int experience)
    {
        this.health = health;
        this.experience = experience;
    }
    public void TakeAttack(int attackPoints)
    {
        if (this.IsDead())
        {
            throw new InvalidOperationException("Dummy is dead.");
        }

        this.health -= attackPoints;
    }

    public int GiveExperience()
    {
        if (!this.IsDead())
        {
            throw new InvalidOperationException("Target is not dead.");
        }

        return this.experience;
    }

    public bool IsDead()
    {
        return this.health <= 0;
    }

    public int health { get; private set; }
    public int experience { get; private set; }
}
