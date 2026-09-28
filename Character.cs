namespace DotNetLessons;

public partial class Character(int health, int damage)
{
    public Attribute Health { get; } = new(health);
    public Attribute Damage { get; } = new(damage);

    public void TakeDamage(int value)
    {
        if (value < 0)
            throw new InvalidAttributeException(
                "Health",
                "Damage value cannot be negative."
            );

        Health.AddToBaseValue(-value);
    }

    public void Heal(int value)
    {
        if (value < 0)
            throw new InvalidAttributeException(
                "Health",
                "Heal value cannot be negative."
            );

        Health.AddToBaseValue(value);
    }

    public void Deconstruct(out int health, out int damage)
    {
        health = Health.Value;
        damage = Damage.Value;
    }
}