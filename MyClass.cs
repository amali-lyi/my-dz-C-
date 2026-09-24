namespace DotNetLessons;

public enum AttributeBonusType
{
    Add,
    Multiply
}

public struct AttributeBonus
{
    public string Tag;
    public AttributeBonusType Type;
    public int Value;
}

public class Attribute(int baseValue)
{
    public int? MinValue { get; set; }
    public int? MaxValue { get; set; }

    public int Value
    {
        get
        {
            double value = BaseValue;

            value += Bonuses
                .Where(bonus => bonus.Type == AttributeBonusType.Add)
                .Sum(bonus => bonus.Value);

            foreach (var bonus in Bonuses
                .Where(bonus => bonus.Type == AttributeBonusType.Multiply))
            {
                value *= bonus.Value / 100.0;
            }

            if (MinValue.HasValue && value < MinValue.Value)
                value = MinValue.Value;

            if (MaxValue.HasValue && value > MaxValue.Value)
                value = MaxValue.Value;

            return (int)value;
        }
    }

    public int BaseValue { get; set; } = baseValue;
    private List<AttributeBonus> Bonuses { get; } = [];

    public void AddBonus(string tag, AttributeBonusType type, int value)
        => Bonuses.Add(new AttributeBonus
        {
            Tag = tag,
            Type = type,
            Value = value
        });

    public void RemoveBonus(string tag)
    {
        var bonusesToRemove = Bonuses
            .Where(bonus => bonus.Tag == tag)
            .ToList();

        foreach (var bonus in bonusesToRemove)
            Bonuses.Remove(bonus);
    }
}

public class Character(int health, int damage)
{
    public Attribute Health { get; } = new(health);
    public Attribute Damage { get; } = new(damage);

    public override string ToString() => $"{nameof(Health)}:{Health.Value}; {nameof(Damage)}:{Damage.Value}";

    public void TakeDamage(int value) => Health.BaseValue -= value;
    public void Heal(int value) => Health.BaseValue += value;
}