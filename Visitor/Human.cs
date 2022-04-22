using System;
public interface Human
{
    void Hit(Monster monster); // Accept
}

public class Warrior : Human
{
    public void Hit(Monster monster)
    {
        Console.WriteLine("Warrior attack");
        monster.HitBy(this);
    }
}

public class Wizard : Human
{
    public void Hit(Monster monster)
    {
        Console.WriteLine("Wizard attack");
        monster.HitBy(this);
    }
}