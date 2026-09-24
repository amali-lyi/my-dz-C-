using DotNetLessons;

Character ch_1 = new Character(health: 100, damage: 5);

Character ch_2 = new Character(health: 100, damage: 5);

Console.WriteLine($"{nameof(ch_1)} - {ch_1}");

Console.WriteLine($"{nameof(ch_2)} - {ch_2}");

Console.WriteLine();

ch_2.Damage.AddBonus(
    tag: "Potion.Damage",
    type: AttributeBonusType.Add,
    value: 10);

ch_1.TakeDamage(ch_2.Damage.Value);

Console.WriteLine($"{nameof(ch_1)} - {ch_1}");

Console.WriteLine($"{nameof(ch_2)} - {ch_2}");

Console.WriteLine();

ch_2.Damage.RemoveBonus(tag: "Potion.Damage");

ch_1.TakeDamage(ch_2.Damage.Value);

Console.WriteLine($"{nameof(ch_1)} - {ch_1}");

Console.WriteLine($"{nameof(ch_2)} - {ch_2}");

Console.WriteLine();