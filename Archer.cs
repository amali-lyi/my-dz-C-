namespace ConsoleGame;

class Archer : Character
{
    public int Arrows { get; set; }

    public Archer(string name, int health, int damage, int arrows)
        : base(name, health, damage)
    {
        Arrows = arrows;
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} attack");
    }

    public override void Attack(Character target)
    {
        Console.WriteLine($"{Name} attack {target.Name}");
        target.TakeDamage(Damage);
        Arrows--;
    }
}