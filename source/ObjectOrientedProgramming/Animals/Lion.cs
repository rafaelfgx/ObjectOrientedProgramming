namespace ObjectOrientedProgramming;

public sealed record Lion : Animal
{
    public Lion() : base(nameof(Lion)) { }

    public override string Sound() => "Roar";
}
