using System;

public interface Monster // Visitor
{
    void HitBy(Warrior warrior); // Visit Warrior
    void HitBy(Wizard wizard); // Visit Wizard
}

public class CuteDogie : Monster
{
    public void HitBy(Warrior warrior)
    {
        Damaged(50);
    }

    public void HitBy(Wizard wizard)
    {
        Damaged(10);
    }

    private void Damaged(int hp)
    {
        Console.WriteLine("Woof! I lost " + hp + "hp.");
    }
}

public class Dracula : Monster
{
    public void HitBy(Warrior warrior)
    {
        damaged(10);
    }

    public void HitBy(Wizard wizard)
    {
        damaged(80);
    }

    private void damaged(int hp)
    {
        Console.WriteLine("Owie! I lost " + hp + "hp.");
    }
}