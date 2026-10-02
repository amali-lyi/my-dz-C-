namespace ConsoleGame;

class Mage : Character
{
    public int Mana { get; set; }

    public Mage(string name, int health, int damage, int mana)
        : base(name, health, damage)
    {
        Mana = mana;
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