namespace DotNetLessons;

public partial class Character
{
    public override string ToString() =>
        $"{nameof(Health)}:{Health.Value}; {nameof(Damage)}:{Damage.Value}";
}