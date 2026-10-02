namespace ConsoleGame;

class Program
{
    static void Main()
    {
        Warrior warrior = new("Warrior", 100, 20, 10);
        Mage mage = new("Mage", 80, 30, 50);
        Archer archer = new("Archer", 70, 25, 10);

        Enemy enemy = new("Enemy", 60, 15, 1);
        StrongEnemy strongEnemy = new("Strong Enemy", 120, 25, 3);
        FastEnemy fastEnemy = new("Fast Enemy", 50, 20, 2);

        List<Character> characters = new()
        {
            warrior,
            mage,
            archer,
            enemy,
            strongEnemy,
            fastEnemy
        };

        foreach (Character character in characters)
        {
            character.Attack();
        }

        Console.WriteLine();

        warrior.Attack(enemy);
        mage.Attack(strongEnemy);
        archer.Attack(fastEnemy);

        Console.WriteLine();

        Console.WriteLine($"{enemy.Name}: {enemy.Health} HP");
        Console.WriteLine($"{strongEnemy.Name}: {strongEnemy.Health} HP");
        Console.WriteLine($"{fastEnemy.Name}: {fastEnemy.Health} HP");
    }
}