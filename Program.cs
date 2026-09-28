namespace DotNetLessons;

class Program
{
    static void Main()
    {
        Character character = new(100, 20);

        character.Health.AddBonuses(
            ("armor", 10),
            ("potion", 5)
        );

        var (health, damage) = character;

        Console.WriteLine($"Health: {health}");
        Console.WriteLine($"Damage: {damage}");

        try
        {
            character.TakeDamage(-10);
        }
        catch (InvalidAttributeException ex) when (ex.AttributeName == "Health")
        {
            Console.WriteLine($"Health error: {ex.Message}");
        }
        catch (InvalidAttributeException ex) when (ex.AttributeName == "Damage")
        {
            Console.WriteLine($"Damage error: {ex.Message}");
        }
    }
}