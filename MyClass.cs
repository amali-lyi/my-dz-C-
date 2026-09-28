namespace DotNetLessons;

public class Attribute(int baseValue)
{
    public int Value => BaseValue + Bonuses.Sum(bonus => bonus.Value);

    public int BaseValue { get; set; } = baseValue;
    private List<(string Tag, int Value)> Bonuses { get; } = [];

    public void AddBonus(string tag, int value) => Bonuses.Add((tag, value));

    public void AddBonuses(params (string Tag, int Value)[] bonuses)
    {
        foreach (var bonus in bonuses)
            Bonuses.Add(bonus);
    }

    public void RemoveBonus(string tag)
    {
        var bonusesToRemove = Bonuses
            .Where(bonus => bonus.Tag == tag)
            .ToList();

        foreach (var bonus in bonusesToRemove)
            Bonuses.Remove(bonus);
    }

    public void AddToBaseValue(int value)
    {
        checked
        {
            BaseValue += value;
        }
    }
}