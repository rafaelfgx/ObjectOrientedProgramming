namespace ObjectOrientedProgramming;

public sealed record Eagle : Animal
{
    public Eagle() : base(nameof(Eagle)) { }

    public override string Move() => "Fly";

    public override string Sound() => "Screech";
}
