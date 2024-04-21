using System;

public class StartUp
{
    static void Main(string[] args)
    {
        Dummy dummy = new Dummy(10, 0);
        Axe axe = new Axe(2, 2);
        Hero hero = new Hero("SuperPuperHero", axe);

        hero.Attack(dummy);

        Console.Write(dummy.Health);
    }
}
