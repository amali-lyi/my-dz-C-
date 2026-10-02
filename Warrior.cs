namespace ConsoleGame;

class Warrior : Character
{
    public int Armor { get; set; }

    public Warrior(string name, int health, int damage, int armor)
        : base(name, health, damage)
    {
        Armor = armor;
    }

    public override void Attack()
    {
        Console.WriteLine($"{Name} attack");
    }

    public override void Attack(Character target)
    {
        Console.WriteLine($"{Name} attack {target.Name}");
        target.TakeDamage(Damage);
    }
}