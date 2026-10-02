namespace ConsoleGame;

abstract class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int Damage { get; set; }

    public Character(string name, int health, int damage)
    {
        Name = name;
        Health = health;
        Damage = damage;
    }

    public virtual void TakeDamage(int damage)
    {
        Health -= damage;

        if (Health <= 0)
        {
            Health = 0;
            Console.WriteLine($"{Name} died");
        }
    }

    public abstract void Attack();

    public abstract void Attack(Character target);
}