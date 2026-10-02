namespace ConsoleGame;

class StrongEnemy : Enemy
{
    public StrongEnemy(string name, int health, int damage, int level)
        : base(name, health, damage, level)
    {
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} attack");
    }
}