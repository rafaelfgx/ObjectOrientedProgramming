namespace ObjectOrientedProgramming;

public sealed record Lion() : Animal(nameof(Lion))
{
    public override string Sound() => "Roar";
}
