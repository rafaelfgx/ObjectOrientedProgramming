namespace ObjectOrientedProgramming;

public sealed record Eagle() : Animal(nameof(Eagle))
{
    public override string Move() => "Fly";

    public override string Sound() => "Screech";
}
