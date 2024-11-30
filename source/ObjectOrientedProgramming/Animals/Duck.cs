namespace ObjectOrientedProgramming;

public sealed record Duck() : Animal(nameof(Duck))
{
    public override string Move() => "Swim";

    public override string Sound() => "Quack";
}
